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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
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
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(249, 78);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(86, 19);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Mitigations";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(249, 103);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(143, 19);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "PowerShell Hardening";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(249, 128);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(185, 19);
            this.checkBox3.TabIndex = 4;
            this.checkBox3.Text = "Windows Defender Hardening";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Location = new System.Drawing.Point(249, 153);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(151, 19);
            this.checkBox4.TabIndex = 5;
            this.checkBox4.Text = "Debloat AppX Packages";
            this.checkBox4.UseVisualStyleBackColor = true;
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
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.Location = new System.Drawing.Point(249, 178);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(103, 19);
            this.checkBox5.TabIndex = 7;
            this.checkBox5.Text = "SSL Hardening";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Checked = true;
            this.checkBox6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox6.Location = new System.Drawing.Point(249, 203);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(109, 19);
            this.checkBox6.TabIndex = 8;
            this.checkBox6.Text = "SMB Hardening";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Checked = true;
            this.checkBox7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox7.Location = new System.Drawing.Point(249, 228);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(124, 19);
            this.checkBox7.TabIndex = 9;
            this.checkBox7.Text = "Remove Bloatware";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Checked = true;
            this.checkBox8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox8.Location = new System.Drawing.Point(249, 253);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(118, 19);
            this.checkBox8.TabIndex = 10;
            this.checkBox8.Text = "Disable Telemetry";
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Checked = true;
            this.checkBox9.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox9.Location = new System.Drawing.Point(249, 279);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(146, 19);
            this.checkBox9.TabIndex = 11;
            this.checkBox9.Text = "Privacy Configurations";
            this.checkBox9.UseVisualStyleBackColor = true;
            this.checkBox9.CheckedChanged += new System.EventHandler(this.checkBox9_CheckedChanged);
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Checked = true;
            this.checkBox10.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox10.Location = new System.Drawing.Point(453, 78);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(106, 19);
            this.checkBox10.TabIndex = 12;
            this.checkBox10.Text = "Image Cleanup";
            this.checkBox10.UseVisualStyleBackColor = true;
            this.checkBox10.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Checked = true;
            this.checkBox11.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox11.Location = new System.Drawing.Point(453, 103);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(117, 19);
            this.checkBox11.TabIndex = 13;
            this.checkBox11.Text = "Nessus PID 63155";
            this.checkBox11.UseVisualStyleBackColor = true;
            this.checkBox11.CheckedChanged += new System.EventHandler(this.checkBox11_CheckedChanged);
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Checked = true;
            this.checkBox12.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox12.Location = new System.Drawing.Point(453, 128);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(181, 19);
            this.checkBox12.TabIndex = 14;
            this.checkBox12.Text = "Install and Configure Sysmon";
            this.checkBox12.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.checkBox12);
            this.Controls.Add(this.checkBox11);
            this.Controls.Add(this.checkBox10);
            this.Controls.Add(this.checkBox9);
            this.Controls.Add(this.checkBox8);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
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
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private Label label1;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private CheckBox checkBox7;
        private CheckBox checkBox8;
        private CheckBox checkBox9;
        private CheckBox checkBox10;
        private CheckBox checkBox11;
        private CheckBox checkBox12;
        private Button Executebutton1;
        private Label copyrightlabel;
        private TextBox commandoutputbox;
        private Label commandoutputlabel;
        private Button stopbutton;
        private Label titlelabel;
    }
}