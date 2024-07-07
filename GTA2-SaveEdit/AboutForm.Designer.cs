
namespace GTA2_SaveEdit
{
    partial class AboutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.lblProgramName = new System.Windows.Forms.Label();
            this.lblAuthorName = new System.Windows.Forms.Label();
            this.lblSeparator = new System.Windows.Forms.Label();
            this.llbGitHub = new System.Windows.Forms.LinkLabel();
            this.lblAbout1 = new System.Windows.Forms.Label();
            this.lblAbout2 = new System.Windows.Forms.Label();
            this.lblAbout3 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblAbout4 = new System.Windows.Forms.Label();
            this.picGTA2 = new System.Windows.Forms.PictureBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblAbout6 = new System.Windows.Forms.Label();
            this.lblAbout5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picGTA2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProgramName
            // 
            this.lblProgramName.AutoSize = true;
            this.lblProgramName.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgramName.Location = new System.Drawing.Point(78, 83);
            this.lblProgramName.Name = "lblProgramName";
            this.lblProgramName.Size = new System.Drawing.Size(128, 24);
            this.lblProgramName.TabIndex = 2;
            this.lblProgramName.Text = "GTA2-SaveEdit";
            // 
            // lblAuthorName
            // 
            this.lblAuthorName.AutoSize = true;
            this.lblAuthorName.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthorName.Location = new System.Drawing.Point(87, 121);
            this.lblAuthorName.Name = "lblAuthorName";
            this.lblAuthorName.Size = new System.Drawing.Size(112, 17);
            this.lblAuthorName.TabIndex = 3;
            this.lblAuthorName.Text = "by Julian Ozel Rose";
            // 
            // lblSeparator
            // 
            this.lblSeparator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSeparator.ForeColor = System.Drawing.Color.Gray;
            this.lblSeparator.Location = new System.Drawing.Point(5, 184);
            this.lblSeparator.Name = "lblSeparator";
            this.lblSeparator.Size = new System.Drawing.Size(275, 2);
            this.lblSeparator.TabIndex = 4;
            // 
            // llbGitHub
            // 
            this.llbGitHub.AutoSize = true;
            this.llbGitHub.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbGitHub.Location = new System.Drawing.Point(113, 147);
            this.llbGitHub.Name = "llbGitHub";
            this.llbGitHub.Size = new System.Drawing.Size(54, 20);
            this.llbGitHub.TabIndex = 5;
            this.llbGitHub.TabStop = true;
            this.llbGitHub.Text = "GitHub";
            this.llbGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbGitHub_LinkClicked);
            // 
            // lblAbout1
            // 
            this.lblAbout1.AutoSize = true;
            this.lblAbout1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbout1.Location = new System.Drawing.Point(10, 200);
            this.lblAbout1.Name = "lblAbout1";
            this.lblAbout1.Size = new System.Drawing.Size(246, 16);
            this.lblAbout1.TabIndex = 6;
            this.lblAbout1.Text = "• Ammo values max out at 255 but reset to 99";
            // 
            // lblAbout2
            // 
            this.lblAbout2.AutoSize = true;
            this.lblAbout2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbout2.Location = new System.Drawing.Point(18, 217);
            this.lblAbout2.Name = "lblAbout2";
            this.lblAbout2.Size = new System.Drawing.Size(182, 16);
            this.lblAbout2.TabIndex = 7;
            this.lblAbout2.Text = "when picking up ammo in game.";
            // 
            // lblAbout3
            // 
            this.lblAbout3.AutoSize = true;
            this.lblAbout3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbout3.Location = new System.Drawing.Point(10, 244);
            this.lblAbout3.Name = "lblAbout3";
            this.lblAbout3.Size = new System.Drawing.Size(247, 16);
            this.lblAbout3.TabIndex = 8;
            this.lblAbout3.Text = "• Lives and multiplier max out at 255 but reset";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(94, 336);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(102, 29);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblAbout4
            // 
            this.lblAbout4.AutoSize = true;
            this.lblAbout4.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbout4.Location = new System.Drawing.Point(18, 260);
            this.lblAbout4.Name = "lblAbout4";
            this.lblAbout4.Size = new System.Drawing.Size(197, 16);
            this.lblAbout4.TabIndex = 12;
            this.lblAbout4.Text = "to 99 when the game is saved again.";
            // 
            // picGTA2
            // 
            this.picGTA2.Image = global::GTA2_SaveEdit.Properties.Resources.GTA2_logo_black;
            this.picGTA2.Location = new System.Drawing.Point(33, 12);
            this.picGTA2.Name = "picGTA2";
            this.picGTA2.Size = new System.Drawing.Size(220, 56);
            this.picGTA2.TabIndex = 0;
            this.picGTA2.TabStop = false;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(99, 105);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(79, 17);
            this.lblVersion.TabIndex = 13;
            this.lblVersion.Text = "Version 1.04";
            // 
            // lblAbout6
            // 
            this.lblAbout6.AutoSize = true;
            this.lblAbout6.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbout6.Location = new System.Drawing.Point(18, 304);
            this.lblAbout6.Name = "lblAbout6";
            this.lblAbout6.Size = new System.Drawing.Size(201, 16);
            this.lblAbout6.TabIndex = 15;
            this.lblAbout6.Text = "reactivate after saving and reloading.";
            // 
            // lblAbout5
            // 
            this.lblAbout5.AutoSize = true;
            this.lblAbout5.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbout5.Location = new System.Drawing.Point(10, 288);
            this.lblAbout5.Name = "lblAbout5";
            this.lblAbout5.Size = new System.Drawing.Size(234, 16);
            this.lblAbout5.TabIndex = 14;
            this.lblAbout5.Text = "• Power-ups last for around 45 minutes but";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 379);
            this.Controls.Add(this.lblAbout6);
            this.Controls.Add(this.lblAbout5);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblAbout4);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblAbout3);
            this.Controls.Add(this.lblAbout2);
            this.Controls.Add(this.lblAbout1);
            this.Controls.Add(this.llbGitHub);
            this.Controls.Add(this.lblSeparator);
            this.Controls.Add(this.lblAuthorName);
            this.Controls.Add(this.lblProgramName);
            this.Controls.Add(this.picGTA2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.picGTA2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picGTA2;
        private System.Windows.Forms.Label lblProgramName;
        private System.Windows.Forms.Label lblAuthorName;
        private System.Windows.Forms.Label lblSeparator;
        private System.Windows.Forms.LinkLabel llbGitHub;
        private System.Windows.Forms.Label lblAbout1;
        private System.Windows.Forms.Label lblAbout2;
        private System.Windows.Forms.Label lblAbout3;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblAbout4;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblAbout6;
        private System.Windows.Forms.Label lblAbout5;
    }
}