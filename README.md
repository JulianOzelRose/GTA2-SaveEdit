# Grand Theft Auto 2 - Savegame Editor
This is a standalone savegame editor for Grand Theft Auto 2. With this tool, you can change ammunition for every weapon, as well as
change cash, health, armor, lives, wanted level. You can also enable power-ups, including Invulnerability, Invisibility, Double Damage,
Fast Reload, and ElectroFingers. To use this tool, simply navigate to the [Release](https://github.com/JulianOzelRose/GTA2-SaveEdit/tree/master/GTA2-SaveEdit/bin/x64/Release)
folder, then download and run ```GTA2-SaveEdit.exe```. No installation is necessary; simply download and run. To edit a savegame, navigate
to your GTA 2 directory. GTA 2 savegame files are in .svg format. They should be located in the following directory: <br>

```C:\Program Files (x86)\Rockstar Games\GTA2\player```<br>

This tool automatically creates backups of your savegame as a precaution, which will have the identical name to the original save with ".bak"
added to the end. Once a savegame is loaded, you can modify to your desire. You can click ```Reload``` to update the values after saving through the game.
Note that ammo values max out at 255, but will reset to 99 when picking up ammo in game. Lives and the point multiplier max out at 255, but reset to 99
when the game is saved. Enabling power-ups sets a hacked time value, so they will last around 45 minutes. When they wear off, saving and reloading
the game will reactivate them.

![GTA2-SaveEdit-UI](https://github.com/JulianOzelRose/GTA2-SaveEdit/assets/95890436/314d21aa-07cc-40ff-8d57-d5b0602b76ea)

## Offset table
Most of these values are stored as bytes, with the exception of cash which is of UInt32 type. There is no enabling or disabling weapons;
simply giving a weapon an ammo value will enable it, and setting the ammo to 0 will disable it. For the power-ups, a value of 0 indicates
the power-up is inactive. Similar to ammo, there is no enabling or disabling power-ups; the variable is essentially a timer value. Each
byte corresponds to approximately 10 seconds, so setting a power-up to 0xFF will set the power-up active for around 45 minutes.

| **File offset**    | **Type**       | **Variable**                      |
| :---               | :---           | :---                              |
| 0x64               | UInt32         | Cash                              |
| 0x68               | BYTE           | Lives                             |
| 0x6C               | BYTE           | Health                            |
| 0x74               | BYTE           | Armor                             |
| 0x76               | BYTE           | Get Outta Jail Free Card Power-Up |
| 0x7B               | BYTE           | Invulnerability Power-Up          |
| 0x7D               | BYTE           | Double Damage Power-Up            |
| 0x7F               | BYTE           | Fast Reload Power-Up              |
| 0x81               | BYTE           | ElectroFingers Power-Up           |
| 0x85               | BYTE           | Invisibility Power-Up             |
| 0xBA               | BYTE           | Pistol Ammo                       |
| 0xBB               | BYTE           | S-Uzi Machine Gun Ammo            |
| 0xBC               | BYTE           | Rocket Launcher Ammo              |
| 0xBD               | BYTE           | ElectroGun Ammo                   |
| 0xBE               | BYTE           | Molotov Cocktails                 |
| 0xBF               | BYTE           | Grenades                          |
| 0xC0               | BYTE           | Shotgun Ammo                      |
| 0xC1               | BYTE           | ElectroBaton Ammo                 |
| 0xC2               | BYTE           | Flamethrower Ammo                 |
| 0xC3               | BYTE           | Silenced S-Uzi Machine Gun Ammo   |
| 0xC4               | BYTE           | Dual Pistol Ammo                  |
| 0xD4               | BYTE           | Point Multiplier                  |
| 0xD6               | BYTE           | Weapon Equipped                   |
| 0xE1               | BYTE           | Wanted Level                      |
