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
            this.label1 = new System.Windows.Forms.Label();
            this.Executebutton1 = new System.Windows.Forms.Button();
            this.copyrightlabel = new System.Windows.Forms.Label();
            this.commandoutputbox = new System.Windows.Forms.TextBox();
            this.commandoutputlabel = new System.Windows.Forms.Label();
            this.stopbutton = new System.Windows.Forms.Button();
            this.titlelabel = new System.Windows.Forms.Label();
            this.SoScheckedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SoScheckedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.SoScheckedListBox4 = new System.Windows.Forms.CheckedListBox();
            this.SoScheckedListBox3 = new System.Windows.Forms.CheckedListBox();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "SoS Configurations:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.commandoutputbox.Location = new System.Drawing.Point(9, 328);
            this.commandoutputbox.Multiline = true;
            this.commandoutputbox.Name = "commandoutputbox";
            this.commandoutputbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.commandoutputbox.Size = new System.Drawing.Size(619, 180);
            this.commandoutputbox.TabIndex = 17;
            // 
            // commandoutputlabel
            // 
            this.commandoutputlabel.AutoSize = true;
            this.commandoutputlabel.Location = new System.Drawing.Point(7, 310);
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
            // SoScheckedListBox1
            // 
            this.SoScheckedListBox1.CheckOnClick = true;
            this.SoScheckedListBox1.FormattingEnabled = true;
            this.SoScheckedListBox1.Items.AddRange(new object[] {
            "Clear Existing GPOs",
            "Image Cleanup",
            "Install Windows Updates"});
            this.SoScheckedListBox1.Location = new System.Drawing.Point(213, 78);
            this.SoScheckedListBox1.Name = "SoScheckedListBox1";
            this.SoScheckedListBox1.Size = new System.Drawing.Size(182, 58);
            this.SoScheckedListBox1.TabIndex = 21;
            // 
            // SoScheckedListBox2
            // 
            this.SoScheckedListBox2.CheckOnClick = true;
            this.SoScheckedListBox2.FormattingEnabled = true;
            this.SoScheckedListBox2.Items.AddRange(new object[] {
            "Applocker Hardening",
            "Bitlocker Hardening",
            "EMET Hardening",
            "PowerShell Hardening",
            "SMB Hardening",
            "SSL Hardening",
            "Windows Defender Hardening"});
            this.SoScheckedListBox2.Location = new System.Drawing.Point(212, 151);
            this.SoScheckedListBox2.Name = "SoScheckedListBox2";
            this.SoScheckedListBox2.Size = new System.Drawing.Size(183, 130);
            this.SoScheckedListBox2.TabIndex = 22;
            // 
            // SoScheckedListBox4
            // 
            this.SoScheckedListBox4.CheckOnClick = true;
            this.SoScheckedListBox4.FormattingEnabled = true;
            this.SoScheckedListBox4.Items.AddRange(new object[] {
            "Disable Telemetry",
            "Enable Device Guard",
            "Enable Disk Compression",
            "General Mitigations",
            "Nessus PID 63155 ",
            "Privacy Configurations",
            "Remove Bloatware"});
            this.SoScheckedListBox4.Location = new System.Drawing.Point(401, 151);
            this.SoScheckedListBox4.Name = "SoScheckedListBox4";
            this.SoScheckedListBox4.Size = new System.Drawing.Size(183, 130);
            this.SoScheckedListBox4.TabIndex = 23;
            // 
            // SoScheckedListBox3
            // 
            this.SoScheckedListBox3.CheckOnClick = true;
            this.SoScheckedListBox3.FormattingEnabled = true;
            this.SoScheckedListBox3.Items.AddRange(new object[] {
            "Browser Configurations",
            "Sysmon Configurations",
            "Update Optimizations"});
            this.SoScheckedListBox3.Location = new System.Drawing.Point(402, 78);
            this.SoScheckedListBox3.Name = "SoScheckedListBox3";
            this.SoScheckedListBox3.Size = new System.Drawing.Size(182, 58);
            this.SoScheckedListBox3.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 597);
            this.Controls.Add(this.SoScheckedListBox3);
            this.Controls.Add(this.SoScheckedListBox4);
            this.Controls.Add(this.SoScheckedListBox2);
            this.Controls.Add(this.SoScheckedListBox1);
            this.Controls.Add(this.titlelabel);
            this.Controls.Add(this.stopbutton);
            this.Controls.Add(this.commandoutputlabel);
            this.Controls.Add(this.commandoutputbox);
            this.Controls.Add(this.copyrightlabel);
            this.Controls.Add(this.Executebutton1);
            this.Controls.Add(this.label1);
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
        private Label label1;
        private Button Executebutton1;
        private Label copyrightlabel;
        private TextBox commandoutputbox;
        private Label commandoutputlabel;
        private Button stopbutton;
        private Label titlelabel;
        private CheckedListBox SoScheckedListBox1;
        private CheckedListBox SoScheckedListBox2;
        private CheckedListBox SoScheckedListBox4;
        private CheckedListBox SoScheckedListBox3;
    }
}