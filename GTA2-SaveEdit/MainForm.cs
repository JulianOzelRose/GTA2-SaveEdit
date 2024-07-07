using System;
using System.IO;
using System.Windows.Forms;

namespace GTA2_SaveEdit
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Offsets
        private const int cashOffset = 0x64;
        private const int livesOffset = 0x68;
        private const int healthOffset = 0x6C;
        private const int armorOffset = 0x74;
        private const int invulnerabilityOffset = 0x7B;
        private const int doubleDamageOffset = 0x7D;
        private const int fastReloadOffset = 0x7F;
        private const int electroFingersOffset = 0x81;
        private const int invisibilityOffset = 0x85;
        private const int pistolAmmoOffset = 0xBA;
        private const int sUziAmmoOffset = 0xBB;
        private const int rocketLauncherAmmoOffset = 0xBC;
        private const int electroGunAmmoOffset = 0xBD;
        private const int molotovCocktailOffset = 0xBE;
        private const int grenadeOffset = 0xBF;
        private const int shotgunAmmoOffset = 0xC0;
        private const int electroBatonOffset = 0xC1;
        private const int flamethrowerAmmoOffset = 0xC2;
        private const int silencedSUziAmmoOffset = 0xC3;
        private const int dualPistolAmmoOffset = 0xC4;
        private const int multiplierOffset = 0xD4;
        private const int wantedLevelOffset = 0xE1;

        // Strings
        private string savegamePath;
        private string savegameDirectory = "c:\\";

        private byte ReadByte(int offset)
        {
            using (FileStream saveFile = new FileStream(savegamePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                saveFile.Seek(offset, SeekOrigin.Begin);
                return (byte)saveFile.ReadByte();
            }
        }

        private void WriteByte(int offset, byte value)
        {
            using (FileStream saveFile = new FileStream(savegamePath, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
            {
                saveFile.Seek(offset, SeekOrigin.Begin);
                byte[] byteData = { value };
                saveFile.Write(byteData, 0, byteData.Length);
            }
        }

        private Int32 ReadInt32(int offset)
        {
            byte byte1 = ReadByte(offset);
            byte byte2 = ReadByte(offset + 1);
            byte byte3 = ReadByte(offset + 2);
            byte byte4 = ReadByte(offset + 3);

            return (Int32)(byte1 + (byte2 << 8) + (byte3 << 16) + (byte4 << 24));
        }

        private void WriteInt32(int offset, Int32 value)
        {
            WriteByte(offset, (byte)value);
            WriteByte(offset + 1, (byte)(value >> 8));
            WriteByte(offset + 2, (byte)(value >> 16));
            WriteByte(offset + 3, (byte)(value >> 24));
        }

        private void CreateBackup(string filePath)
        {
            string directory = Path.GetDirectoryName(filePath);
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(filePath);
            string fileExtension = Path.GetExtension(filePath);

            string backupFilePath = Path.Combine(directory, $"{fileNameWithoutExtension}{fileExtension}.bak");

            if (File.Exists(backupFilePath))
            {
                File.SetAttributes(backupFilePath, File.GetAttributes(backupFilePath) & ~FileAttributes.ReadOnly);
            }

            File.Copy(filePath, backupFilePath, true);
        }

        private byte GetWantedLevel()
        {
            byte data = ReadByte(wantedLevelOffset);
            byte wantedLevel = 0;

            if (data <= 0x1)
            {
                wantedLevel = 0;
            }
            else if (data >= 0x2 && data <= 0x5)
            {
                wantedLevel = 1;
            }
            else if (data >= 0x6 && data <= 0xA)
            {
                wantedLevel = 2;
            }
            else if (data >= 0xB && data <= 0x12)
            {
                wantedLevel = 3;
            }
            else if (data >= 0x13 && data <= 0x1E)
            {
                wantedLevel = 4;
            }
            else if (data >= 0x1F && data <= 0x2D)
            {
                wantedLevel = 5;
            }
            else if (data >= 0x2E)
            {
                wantedLevel = 6;
            }

            return wantedLevel;
        }

        private void WriteWantedLevel(byte wantedLevel)
        {
            if (wantedLevel == 0)
            {
                WriteByte(wantedLevelOffset, 0);
            }
            else if (wantedLevel == 1)
            {
                WriteByte(wantedLevelOffset, 0x4);
            }
            else if (wantedLevel == 2)
            {
                WriteByte(wantedLevelOffset, 0x9);
            }
            else if (wantedLevel == 3)
            {
                WriteByte(wantedLevelOffset, 0xD);
            }
            else if (wantedLevel == 4)
            {
                WriteByte(wantedLevelOffset, 0x17);
            }
            else if (wantedLevel == 5)
            {
                WriteByte(wantedLevelOffset, 0x2A);
            }
            else if (wantedLevel == 6)
            {
                WriteByte(wantedLevelOffset, 0x2F);
            }
        }

        private void ClearControls()
        {
            txtFile.Clear();
            nudCash.Value = 0;
            nudPistolAmmo.Value = 0;
            nudSilencedSUziMachineGunAmmo.Value = 0;
            nudRocketLauncherAmmo.Value = 0;
            nudMolotovCocktails.Value = 0;
            nudGrenades.Value = 0;
            nudShotgunAmmo.Value = 0;
            nudElectroGunAmmo.Value = 0;
            nudFlamethrowerAmmo.Value = 0;
            nudDualPistolAmmo.Value = 0;
            nudElectroBatonAmmo.Value = 0;
            nudSUziMachineGunAmmo.Value = 0;
            nudLives.Value = 0;
            nudMultiplier.Value = 0;
            nudWantedLevel.Value = 0;
            nudHealth.Value = 0;
            nudArmor.Value = 0;
            chkInvulnerability.Checked = false;
            chkDoubleDamage.Checked = false;
            chkFastReload.Checked = false;
            chkElectroFingers.Checked = false;
            chkInvisibility.Checked = false;
        }

        private void DisplayGameData()
        {
            nudCash.Value = ReadInt32(cashOffset);
            nudLives.Value = ReadByte(livesOffset);
            nudMultiplier.Value = ReadByte(multiplierOffset);
            nudPistolAmmo.Value = ReadByte(pistolAmmoOffset);
            nudSilencedSUziMachineGunAmmo.Value = ReadByte(silencedSUziAmmoOffset);
            nudRocketLauncherAmmo.Value = ReadByte(rocketLauncherAmmoOffset);
            nudMolotovCocktails.Value = ReadByte(molotovCocktailOffset);
            nudGrenades.Value = ReadByte(grenadeOffset);
            nudShotgunAmmo.Value = ReadByte(shotgunAmmoOffset);
            nudElectroGunAmmo.Value = ReadByte(electroGunAmmoOffset);
            nudFlamethrowerAmmo.Value = ReadByte(flamethrowerAmmoOffset);
            nudDualPistolAmmo.Value = ReadByte(dualPistolAmmoOffset);
            nudElectroBatonAmmo.Value = ReadByte(electroBatonOffset);
            nudSUziMachineGunAmmo.Value = ReadByte(sUziAmmoOffset);
            nudHealth.Value = ReadByte(healthOffset);
            nudArmor.Value = ReadByte(armorOffset);
            nudWantedLevel.Value = GetWantedLevel();
            chkInvulnerability.Checked = ReadByte(invulnerabilityOffset) != 0;
            chkDoubleDamage.Checked = ReadByte(doubleDamageOffset) != 0;
            chkFastReload.Checked = ReadByte(fastReloadOffset) != 0;
            chkElectroFingers.Checked = ReadByte(electroFingersOffset) != 0;
            chkInvisibility.Checked = ReadByte(invisibilityOffset) != 0;
        }

        private void WriteChanges()
        {
            WriteInt32(cashOffset, (Int32)nudCash.Value);
            WriteByte(livesOffset, (byte)nudLives.Value);
            WriteByte(multiplierOffset, (byte)nudMultiplier.Value);
            WriteByte(pistolAmmoOffset, (byte)nudPistolAmmo.Value);
            WriteByte(silencedSUziAmmoOffset, (byte)nudSilencedSUziMachineGunAmmo.Value);
            WriteByte(rocketLauncherAmmoOffset, (byte)nudRocketLauncherAmmo.Value);
            WriteByte(molotovCocktailOffset, (byte)nudMolotovCocktails.Value);
            WriteByte(grenadeOffset, (byte)nudGrenades.Value);
            WriteByte(shotgunAmmoOffset, (byte)nudShotgunAmmo.Value);
            WriteByte(electroGunAmmoOffset, (byte)nudElectroGunAmmo.Value);
            WriteByte(flamethrowerAmmoOffset, (byte)nudFlamethrowerAmmo.Value);
            WriteByte(dualPistolAmmoOffset, (byte)nudDualPistolAmmo.Value);
            WriteByte(electroBatonOffset, (byte)nudElectroBatonAmmo.Value);
            WriteByte(sUziAmmoOffset, (byte)nudSUziMachineGunAmmo.Value);
            WriteByte(healthOffset, (byte)nudHealth.Value);
            WriteByte(armorOffset, (byte)nudArmor.Value);
            WriteWantedLevel((byte)nudWantedLevel.Value);
            WriteByte(invulnerabilityOffset, chkInvulnerability.Checked ? (byte)0xFF : (byte)0);
            WriteByte(doubleDamageOffset, chkDoubleDamage.Checked ? (byte)0xFF : (byte)0);
            WriteByte(fastReloadOffset, chkFastReload.Checked ? (byte)0xFF : (byte)0);
            WriteByte(electroFingersOffset, chkElectroFingers.Checked ? (byte)0xFF : (byte)0);
            WriteByte(invisibilityOffset, chkInvisibility.Checked ? (byte)0xFF : (byte)0);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = savegameDirectory;
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    string fileExtension = Path.GetExtension(filePath).ToLower();

                    if (fileExtension == ".svg")
                    {
                        savegamePath = filePath;
                        savegameDirectory = Path.GetDirectoryName(filePath);

                        txtFile.Text = filePath;
                        DisplayGameData();
                        btnSave.Enabled = true;
                        btnReload.Enabled = true;
                    }
                    else
                    {
                        ClearControls();
                        btnSave.Enabled = false;
                        btnReload.Enabled = false;
                        MessageBox.Show("Not a valid GTA 2 savegame file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (File.Exists(savegamePath))
            {
                try
                {
                    File.SetAttributes(savegamePath, File.GetAttributes(savegamePath) & ~FileAttributes.ReadOnly);
                    CreateBackup(savegamePath);
                    WriteChanges();
                    MessageBox.Show("Successfully patched savegame.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Could not find file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearControls();
                btnSave.Enabled = false;
                btnReload.Enabled = false;
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            if (File.Exists(savegamePath))
            {
                DisplayGameData();
            }
            else
            {
                ClearControls();
                btnSave.Enabled = false;
                btnReload.Enabled = false;
                MessageBox.Show("File not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }
    }
}
