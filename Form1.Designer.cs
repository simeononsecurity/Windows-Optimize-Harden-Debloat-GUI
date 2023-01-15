namespace Windows_Optimize_Harden_Debloat
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.STIGslabel1 = new System.Windows.Forms.Label();
            this.STIGscheckedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.MitigationscheckBox1 = new System.Windows.Forms.CheckBox();
            this.PSHardeningcheckBox2 = new System.Windows.Forms.CheckBox();
            this.WDHardeningcheckBox3 = new System.Windows.Forms.CheckBox();
            this.DbloatAppXcheckBox4 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SSLHardeningcheckBox5 = new System.Windows.Forms.CheckBox();
            this.SMBHardeningcheckBox6 = new System.Windows.Forms.CheckBox();
            this.RemoveBloatwarecheckBox7 = new System.Windows.Forms.CheckBox();
            this.DisableTelemetrycheckBox8 = new System.Windows.Forms.CheckBox();
            this.PrivacyConfigurationscheckBox9 = new System.Windows.Forms.CheckBox();
            this.ImageCleanupcheckBox10 = new System.Windows.Forms.CheckBox();
            this.NessusPIDcheckBox11 = new System.Windows.Forms.CheckBox();
            this.SysmoncheckBox12 = new System.Windows.Forms.CheckBox();
            this.Executebutton1 = new System.Windows.Forms.Button();
            this.copyrightlabel = new System.Windows.Forms.Label();
            this.commandoutputbox = new System.Windows.Forms.TextBox();
            this.commandoutputlabel = new System.Windows.Forms.Label();
            this.stopbutton = new System.Windows.Forms.Button();
            this.titlelabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // STIGslabel1
            // 
            this.STIGslabel1.AutoSize = true;
            this.STIGslabel1.Location = new System.Drawing.Point(7, 56);
            this.STIGslabel1.Name = "STIGslabel1";
            this.STIGslabel1.Size = new System.Drawing.Size(38, 15);
            this.STIGslabel1.TabIndex = 0;
            this.STIGslabel1.Text = "STIGs:";
            // 
            // STIGscheckedListBox1
            // 
            this.STIGscheckedListBox1.CheckOnClick = true;
            this.STIGscheckedListBox1.FormattingEnabled = true;
            this.STIGscheckedListBox1.Items.AddRange(new object[] {
            "Adobe Acrobat Reader/Pro DC",
            "Firefox",
            "Google Chrome ",
            "Internet Explorer 11",
            "Microsoft Edge",
            "Microsoft .Net Framework",
            "Microsoft Office",
            "Microsoft OneDrive",
            "Oracle JRE 8",
            "Windows 10/11",
            "Windows Defender Antivirus",
            "Windows Firewall"});
            this.STIGscheckedListBox1.Location = new System.Drawing.Point(12, 78);
            this.STIGscheckedListBox1.Name = "STIGscheckedListBox1";
            this.STIGscheckedListBox1.Size = new System.Drawing.Size(195, 220);
            this.STIGscheckedListBox1.TabIndex = 1;
            // 
            // MitigationscheckBox1
            // 
            this.MitigationscheckBox1.AutoSize = true;
            this.MitigationscheckBox1.Checked = true;
            this.MitigationscheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MitigationscheckBox1.Location = new System.Drawing.Point(249, 78);
            this.MitigationscheckBox1.Name = "MitigationscheckBox1";
            this.MitigationscheckBox1.Size = new System.Drawing.Size(86, 19);
            this.MitigationscheckBox1.TabIndex = 2;
            this.MitigationscheckBox1.Text = "Mitigations";
            this.MitigationscheckBox1.UseVisualStyleBackColor = true;
            // 
            // PSHardeningcheckBox2
            // 
            this.PSHardeningcheckBox2.AutoSize = true;
            this.PSHardeningcheckBox2.Checked = true;
            this.PSHardeningcheckBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PSHardeningcheckBox2.Location = new System.Drawing.Point(249, 103);
            this.PSHardeningcheckBox2.Name = "PSHardeningcheckBox2";
            this.PSHardeningcheckBox2.Size = new System.Drawing.Size(143, 19);
            this.PSHardeningcheckBox2.TabIndex = 3;
            this.PSHardeningcheckBox2.Text = "PowerShell Hardening";
            this.PSHardeningcheckBox2.UseVisualStyleBackColor = true;
            // 
            // WDHardeningcheckBox3
            // 
            this.WDHardeningcheckBox3.AutoSize = true;
            this.WDHardeningcheckBox3.Checked = true;
            this.WDHardeningcheckBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WDHardeningcheckBox3.Location = new System.Drawing.Point(249, 128);
            this.WDHardeningcheckBox3.Name = "WDHardeningcheckBox3";
            this.WDHardeningcheckBox3.Size = new System.Drawing.Size(185, 19);
            this.WDHardeningcheckBox3.TabIndex = 4;
            this.WDHardeningcheckBox3.Text = "Windows Defender Hardening";
            this.WDHardeningcheckBox3.UseVisualStyleBackColor = true;
            // 
            // DbloatAppXcheckBox4
            // 
            this.DbloatAppXcheckBox4.AutoSize = true;
            this.DbloatAppXcheckBox4.Checked = true;
            this.DbloatAppXcheckBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DbloatAppXcheckBox4.Location = new System.Drawing.Point(249, 153);
            this.DbloatAppXcheckBox4.Name = "DbloatAppXcheckBox4";
            this.DbloatAppXcheckBox4.Size = new System.Drawing.Size(151, 19);
            this.DbloatAppXcheckBox4.TabIndex = 5;
            this.DbloatAppXcheckBox4.Text = "Debloat AppX Packages";
            this.DbloatAppXcheckBox4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Optional Configurations:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SSLHardeningcheckBox5
            // 
            this.SSLHardeningcheckBox5.AutoSize = true;
            this.SSLHardeningcheckBox5.Checked = true;
            this.SSLHardeningcheckBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SSLHardeningcheckBox5.Location = new System.Drawing.Point(249, 178);
            this.SSLHardeningcheckBox5.Name = "SSLHardeningcheckBox5";
            this.SSLHardeningcheckBox5.Size = new System.Drawing.Size(103, 19);
            this.SSLHardeningcheckBox5.TabIndex = 7;
            this.SSLHardeningcheckBox5.Text = "SSL Hardening";
            this.SSLHardeningcheckBox5.UseVisualStyleBackColor = true;
            // 
            // SMBHardeningcheckBox6
            // 
            this.SMBHardeningcheckBox6.AutoSize = true;
            this.SMBHardeningcheckBox6.Checked = true;
            this.SMBHardeningcheckBox6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SMBHardeningcheckBox6.Location = new System.Drawing.Point(249, 203);
            this.SMBHardeningcheckBox6.Name = "SMBHardeningcheckBox6";
            this.SMBHardeningcheckBox6.Size = new System.Drawing.Size(109, 19);
            this.SMBHardeningcheckBox6.TabIndex = 8;
            this.SMBHardeningcheckBox6.Text = "SMB Hardening";
            this.SMBHardeningcheckBox6.UseVisualStyleBackColor = true;
            // 
            // RemoveBloatwarecheckBox7
            // 
            this.RemoveBloatwarecheckBox7.AutoSize = true;
            this.RemoveBloatwarecheckBox7.Checked = true;
            this.RemoveBloatwarecheckBox7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RemoveBloatwarecheckBox7.Location = new System.Drawing.Point(249, 228);
            this.RemoveBloatwarecheckBox7.Name = "RemoveBloatwarecheckBox7";
            this.RemoveBloatwarecheckBox7.Size = new System.Drawing.Size(124, 19);
            this.RemoveBloatwarecheckBox7.TabIndex = 9;
            this.RemoveBloatwarecheckBox7.Text = "Remove Bloatware";
            this.RemoveBloatwarecheckBox7.UseVisualStyleBackColor = true;
            // 
            // DisableTelemetrycheckBox8
            // 
            this.DisableTelemetrycheckBox8.AutoSize = true;
            this.DisableTelemetrycheckBox8.Checked = true;
            this.DisableTelemetrycheckBox8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DisableTelemetrycheckBox8.Location = new System.Drawing.Point(249, 253);
            this.DisableTelemetrycheckBox8.Name = "DisableTelemetrycheckBox8";
            this.DisableTelemetrycheckBox8.Size = new System.Drawing.Size(118, 19);
            this.DisableTelemetrycheckBox8.TabIndex = 10;
            this.DisableTelemetrycheckBox8.Text = "Disable Telemetry";
            this.DisableTelemetrycheckBox8.UseVisualStyleBackColor = true;
            this.DisableTelemetrycheckBox8.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // PrivacyConfigurationscheckBox9
            // 
            this.PrivacyConfigurationscheckBox9.AutoSize = true;
            this.PrivacyConfigurationscheckBox9.Checked = true;
            this.PrivacyConfigurationscheckBox9.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PrivacyConfigurationscheckBox9.Location = new System.Drawing.Point(249, 279);
            this.PrivacyConfigurationscheckBox9.Name = "PrivacyConfigurationscheckBox9";
            this.PrivacyConfigurationscheckBox9.Size = new System.Drawing.Size(146, 19);
            this.PrivacyConfigurationscheckBox9.TabIndex = 11;
            this.PrivacyConfigurationscheckBox9.Text = "Privacy Configurations";
            this.PrivacyConfigurationscheckBox9.UseVisualStyleBackColor = true;
            this.PrivacyConfigurationscheckBox9.CheckedChanged += new System.EventHandler(this.checkBox9_CheckedChanged);
            // 
            // ImageCleanupcheckBox10
            // 
            this.ImageCleanupcheckBox10.AutoSize = true;
            this.ImageCleanupcheckBox10.Checked = true;
            this.ImageCleanupcheckBox10.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ImageCleanupcheckBox10.Location = new System.Drawing.Point(453, 78);
            this.ImageCleanupcheckBox10.Name = "ImageCleanupcheckBox10";
            this.ImageCleanupcheckBox10.Size = new System.Drawing.Size(106, 19);
            this.ImageCleanupcheckBox10.TabIndex = 12;
            this.ImageCleanupcheckBox10.Text = "Image Cleanup";
            this.ImageCleanupcheckBox10.UseVisualStyleBackColor = true;
            this.ImageCleanupcheckBox10.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
            // 
            // NessusPIDcheckBox11
            // 
            this.NessusPIDcheckBox11.AutoSize = true;
            this.NessusPIDcheckBox11.Checked = true;
            this.NessusPIDcheckBox11.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NessusPIDcheckBox11.Location = new System.Drawing.Point(453, 103);
            this.NessusPIDcheckBox11.Name = "NessusPIDcheckBox11";
            this.NessusPIDcheckBox11.Size = new System.Drawing.Size(117, 19);
            this.NessusPIDcheckBox11.TabIndex = 13;
            this.NessusPIDcheckBox11.Text = "Nessus PID 63155";
            this.NessusPIDcheckBox11.UseVisualStyleBackColor = true;
            this.NessusPIDcheckBox11.CheckedChanged += new System.EventHandler(this.checkBox11_CheckedChanged);
            // 
            // SysmoncheckBox12
            // 
            this.SysmoncheckBox12.AutoSize = true;
            this.SysmoncheckBox12.Checked = true;
            this.SysmoncheckBox12.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SysmoncheckBox12.Location = new System.Drawing.Point(453, 128);
            this.SysmoncheckBox12.Name = "SysmoncheckBox12";
            this.SysmoncheckBox12.Size = new System.Drawing.Size(181, 19);
            this.SysmoncheckBox12.TabIndex = 14;
            this.SysmoncheckBox12.Text = "Install and Configure Sysmon";
            this.SysmoncheckBox12.UseVisualStyleBackColor = true;
            // 
            // Executebutton1
            // 
            this.Executebutton1.Location = new System.Drawing.Point(446, 523);
            this.Executebutton1.Name = "Executebutton1";
            this.Executebutton1.Size = new System.Drawing.Size(175, 65);
            this.Executebutton1.TabIndex = 15;
            this.Executebutton1.Text = "Execute";
            this.Executebutton1.UseVisualStyleBackColor = true;
            this.Executebutton1.Click += new System.EventHandler(this.Executebutton1_Click);
            // 
            // copyrightlabel
            // 
            this.copyrightlabel.AutoSize = true;
            this.copyrightlabel.Location = new System.Drawing.Point(7, 573);
            this.copyrightlabel.Name = "copyrightlabel";
            this.copyrightlabel.Size = new System.Drawing.Size(146, 15);
            this.copyrightlabel.TabIndex = 16;
            this.copyrightlabel.Text = "© SimeonOnSecurity 2023";
            // 
            // commandoutputbox
            // 
            this.commandoutputbox.Location = new System.Drawing.Point(9, 355);
            this.commandoutputbox.Multiline = true;
            this.commandoutputbox.Name = "commandoutputbox";
            this.commandoutputbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.commandoutputbox.Size = new System.Drawing.Size(619, 153);
            this.commandoutputbox.TabIndex = 17;
            // 
            // commandoutputlabel
            // 
            this.commandoutputlabel.AutoSize = true;
            this.commandoutputlabel.Location = new System.Drawing.Point(7, 337);
            this.commandoutputlabel.Name = "commandoutputlabel";
            this.commandoutputlabel.Size = new System.Drawing.Size(108, 15);
            this.commandoutputlabel.TabIndex = 18;
            this.commandoutputlabel.Text = "Command Output:";
            // 
            // stopbutton
            // 
            this.stopbutton.Location = new System.Drawing.Point(265, 523);
            this.stopbutton.Name = "stopbutton";
            this.stopbutton.Size = new System.Drawing.Size(175, 65);
            this.stopbutton.TabIndex = 19;
            this.stopbutton.Text = "Stop";
            this.stopbutton.UseVisualStyleBackColor = true;
            this.stopbutton.Click += new System.EventHandler(this.stopbutton_Click);
            // 
            // titlelabel
            // 
            this.titlelabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titlelabel.AutoSize = true;
            this.titlelabel.Location = new System.Drawing.Point(200, 9);
            this.titlelabel.Name = "titlelabel";
            this.titlelabel.Size = new System.Drawing.Size(216, 15);
            this.titlelabel.TabIndex = 20;
            this.titlelabel.Text = "Windows Optimize Harden and Debloat";
            this.titlelabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 611);
            this.Controls.Add(this.titlelabel);
            this.Controls.Add(this.stopbutton);
            this.Controls.Add(this.commandoutputlabel);
            this.Controls.Add(this.commandoutputbox);
            this.Controls.Add(this.copyrightlabel);
            this.Controls.Add(this.Executebutton1);
            this.Controls.Add(this.SysmoncheckBox12);
            this.Controls.Add(this.NessusPIDcheckBox11);
            this.Controls.Add(this.ImageCleanupcheckBox10);
            this.Controls.Add(this.PrivacyConfigurationscheckBox9);
            this.Controls.Add(this.DisableTelemetrycheckBox8);
            this.Controls.Add(this.RemoveBloatwarecheckBox7);
            this.Controls.Add(this.SMBHardeningcheckBox6);
            this.Controls.Add(this.SSLHardeningcheckBox5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DbloatAppXcheckBox4);
            this.Controls.Add(this.WDHardeningcheckBox3);
            this.Controls.Add(this.PSHardeningcheckBox2);
            this.Controls.Add(this.MitigationscheckBox1);
            this.Controls.Add(this.STIGscheckedListBox1);
            this.Controls.Add(this.STIGslabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Windows Optimize Harden Debloat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label STIGslabel1;
        private CheckedListBox STIGscheckedListBox1;
        private CheckBox MitigationscheckBox1;
        private CheckBox PSHardeningcheckBox2;
        private CheckBox WDHardeningcheckBox3;
        private CheckBox DbloatAppXcheckBox4;
        private Label label1;
        private CheckBox SSLHardeningcheckBox5;
        private CheckBox SMBHardeningcheckBox6;
        private CheckBox RemoveBloatwarecheckBox7;
        private CheckBox DisableTelemetrycheckBox8;
        private CheckBox PrivacyConfigurationscheckBox9;
        private CheckBox ImageCleanupcheckBox10;
        private CheckBox NessusPIDcheckBox11;
        private CheckBox SysmoncheckBox12;
        private Button Executebutton1;
        private Label copyrightlabel;
        private TextBox commandoutputbox;
        private Label commandoutputlabel;
        private Button stopbutton;
        private Label titlelabel;
    }
}