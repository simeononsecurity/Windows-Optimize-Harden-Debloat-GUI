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
            this.Executebutton1 = new System.Windows.Forms.Button();
            this.copyrightlabel = new System.Windows.Forms.Label();
            this.commandoutputlabel = new System.Windows.Forms.Label();
            this.stopbutton = new System.Windows.Forms.Button();
            this.titlelabel = new System.Windows.Forms.Label();
            this.Adobe = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OneDrive = new System.Windows.Forms.CheckBox();
            this.Firewall = new System.Windows.Forms.CheckBox();
            this.Defender = new System.Windows.Forms.CheckBox();
            this.Windows = new System.Windows.Forms.CheckBox();
            this.Office = new System.Windows.Forms.CheckBox();
            this.Java = new System.Windows.Forms.CheckBox();
            this.DotNet = new System.Windows.Forms.CheckBox();
            this.Edge = new System.Windows.Forms.CheckBox();
            this.IE11 = new System.Windows.Forms.CheckBox();
            this.Chrome = new System.Windows.Forms.CheckBox();
            this.FireFox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Privacy = new System.Windows.Forms.CheckBox();
            this.cleargpos = new System.Windows.Forms.CheckBox();
            this.removebloatware = new System.Windows.Forms.CheckBox();
            this.sysmon = new System.Windows.Forms.CheckBox();
            this.nessusPID = new System.Windows.Forms.CheckBox();
            this.sosbrowsers = new System.Windows.Forms.CheckBox();
            this.updatemanagement = new System.Windows.Forms.CheckBox();
            this.Mitigations = new System.Windows.Forms.CheckBox();
            this.installupdates = new System.Windows.Forms.CheckBox();
            this.ApplockerHardening = new System.Windows.Forms.CheckBox();
            this.diskcompression = new System.Windows.Forms.CheckBox();
            this.ImageCleanup = new System.Windows.Forms.CheckBox();
            this.BitlockerHardening = new System.Windows.Forms.CheckBox();
            this.deviceguard = new System.Windows.Forms.CheckBox();
            this.emet = new System.Windows.Forms.CheckBox();
            this.PSHardening = new System.Windows.Forms.CheckBox();
            this.disabletelemetry = new System.Windows.Forms.CheckBox();
            this.SMBHardening = new System.Windows.Forms.CheckBox();
            this.DefenderHardening = new System.Windows.Forms.CheckBox();
            this.CheckAllBx = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Executebutton1
            // 
            this.Executebutton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Executebutton1.Location = new System.Drawing.Point(450, 721);
            this.Executebutton1.Name = "Executebutton1";
            this.Executebutton1.Size = new System.Drawing.Size(175, 65);
            this.Executebutton1.TabIndex = 15;
            this.Executebutton1.Text = "Execute";
            this.Executebutton1.UseVisualStyleBackColor = true;
            this.Executebutton1.Click += new System.EventHandler(this.Executebutton1_Click);
            // 
            // copyrightlabel
            // 
            this.copyrightlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.copyrightlabel.AutoSize = true;
            this.copyrightlabel.Location = new System.Drawing.Point(12, 774);
            this.copyrightlabel.Name = "copyrightlabel";
            this.copyrightlabel.Size = new System.Drawing.Size(146, 15);
            this.copyrightlabel.TabIndex = 16;
            this.copyrightlabel.Text = "© SimeonOnSecurity 2023";
            // 
            // commandoutputlabel
            // 
            this.commandoutputlabel.AutoSize = true;
            this.commandoutputlabel.Location = new System.Drawing.Point(9, 359);
            this.commandoutputlabel.Name = "commandoutputlabel";
            this.commandoutputlabel.Size = new System.Drawing.Size(108, 15);
            this.commandoutputlabel.TabIndex = 18;
            this.commandoutputlabel.Text = "Command Output:";
            // 
            // stopbutton
            // 
            this.stopbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stopbutton.Enabled = false;
            this.stopbutton.Location = new System.Drawing.Point(269, 720);
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
            // 
            // Adobe
            // 
            this.Adobe.AutoSize = true;
            this.Adobe.Location = new System.Drawing.Point(2, 2);
            this.Adobe.Margin = new System.Windows.Forms.Padding(2);
            this.Adobe.Name = "Adobe";
            this.Adobe.Size = new System.Drawing.Size(187, 19);
            this.Adobe.TabIndex = 25;
            this.Adobe.Text = "Adobe Acrobat Reader/Pro DC";
            this.Adobe.UseVisualStyleBackColor = true;
            this.Adobe.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 273);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "STIGs";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.OneDrive);
            this.panel1.Controls.Add(this.Firewall);
            this.panel1.Controls.Add(this.Defender);
            this.panel1.Controls.Add(this.Windows);
            this.panel1.Controls.Add(this.Office);
            this.panel1.Controls.Add(this.Java);
            this.panel1.Controls.Add(this.DotNet);
            this.panel1.Controls.Add(this.Edge);
            this.panel1.Controls.Add(this.IE11);
            this.panel1.Controls.Add(this.Chrome);
            this.panel1.Controls.Add(this.FireFox);
            this.panel1.Controls.Add(this.Adobe);
            this.panel1.Location = new System.Drawing.Point(0, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 246);
            this.panel1.TabIndex = 0;
            // 
            // OneDrive
            // 
            this.OneDrive.AutoSize = true;
            this.OneDrive.Location = new System.Drawing.Point(2, 163);
            this.OneDrive.Margin = new System.Windows.Forms.Padding(2);
            this.OneDrive.Name = "OneDrive";
            this.OneDrive.Size = new System.Drawing.Size(129, 19);
            this.OneDrive.TabIndex = 36;
            this.OneDrive.Text = "Microsoft OneDrive";
            this.OneDrive.UseVisualStyleBackColor = true;
            this.OneDrive.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // Firewall
            // 
            this.Firewall.AutoSize = true;
            this.Firewall.Location = new System.Drawing.Point(2, 255);
            this.Firewall.Margin = new System.Windows.Forms.Padding(2);
            this.Firewall.Name = "Firewall";
            this.Firewall.Size = new System.Drawing.Size(118, 19);
            this.Firewall.TabIndex = 34;
            this.Firewall.Text = "Windows Firewall";
            this.Firewall.UseVisualStyleBackColor = true;
            this.Firewall.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // Defender
            // 
            this.Defender.AutoSize = true;
            this.Defender.Location = new System.Drawing.Point(2, 232);
            this.Defender.Margin = new System.Windows.Forms.Padding(2);
            this.Defender.Name = "Defender";
            this.Defender.Size = new System.Drawing.Size(176, 19);
            this.Defender.TabIndex = 33;
            this.Defender.Text = "Windows Defender Antivirus";
            this.Defender.UseVisualStyleBackColor = true;
            this.Defender.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // Windows
            // 
            this.Windows.AutoSize = true;
            this.Windows.Location = new System.Drawing.Point(2, 209);
            this.Windows.Margin = new System.Windows.Forms.Padding(2);
            this.Windows.Name = "Windows";
            this.Windows.Size = new System.Drawing.Size(107, 19);
            this.Windows.TabIndex = 32;
            this.Windows.Text = "Windows 10/11";
            this.Windows.UseVisualStyleBackColor = true;
            this.Windows.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // Office
            // 
            this.Office.AutoSize = true;
            this.Office.Location = new System.Drawing.Point(2, 140);
            this.Office.Margin = new System.Windows.Forms.Padding(2);
            this.Office.Name = "Office";
            this.Office.Size = new System.Drawing.Size(112, 19);
            this.Office.TabIndex = 35;
            this.Office.Text = "Microsoft Office";
            this.Office.UseVisualStyleBackColor = true;
            this.Office.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // Java
            // 
            this.Java.AutoSize = true;
            this.Java.Location = new System.Drawing.Point(2, 186);
            this.Java.Margin = new System.Windows.Forms.Padding(2);
            this.Java.Name = "Java";
            this.Java.Size = new System.Drawing.Size(89, 19);
            this.Java.TabIndex = 31;
            this.Java.Text = "Oracle JRE 8";
            this.Java.UseVisualStyleBackColor = true;
            this.Java.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // DotNet
            // 
            this.DotNet.AutoSize = true;
            this.DotNet.Location = new System.Drawing.Point(2, 117);
            this.DotNet.Margin = new System.Windows.Forms.Padding(2);
            this.DotNet.Name = "DotNet";
            this.DotNet.Size = new System.Drawing.Size(164, 19);
            this.DotNet.TabIndex = 30;
            this.DotNet.Text = "Microsoft .Net Framework";
            this.DotNet.UseVisualStyleBackColor = true;
            this.DotNet.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // Edge
            // 
            this.Edge.AutoSize = true;
            this.Edge.Location = new System.Drawing.Point(2, 94);
            this.Edge.Margin = new System.Windows.Forms.Padding(2);
            this.Edge.Name = "Edge";
            this.Edge.Size = new System.Drawing.Size(106, 19);
            this.Edge.TabIndex = 29;
            this.Edge.Text = "Microsoft Edge";
            this.Edge.UseVisualStyleBackColor = true;
            this.Edge.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // IE11
            // 
            this.IE11.AutoSize = true;
            this.IE11.Location = new System.Drawing.Point(2, 71);
            this.IE11.Margin = new System.Windows.Forms.Padding(2);
            this.IE11.Name = "IE11";
            this.IE11.Size = new System.Drawing.Size(128, 19);
            this.IE11.TabIndex = 28;
            this.IE11.Text = "Internet Explorer 11";
            this.IE11.UseVisualStyleBackColor = true;
            this.IE11.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // Chrome
            // 
            this.Chrome.AutoSize = true;
            this.Chrome.Location = new System.Drawing.Point(2, 48);
            this.Chrome.Margin = new System.Windows.Forms.Padding(2);
            this.Chrome.Name = "Chrome";
            this.Chrome.Size = new System.Drawing.Size(110, 19);
            this.Chrome.TabIndex = 27;
            this.Chrome.Text = "Google Chrome";
            this.Chrome.UseVisualStyleBackColor = true;
            this.Chrome.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // FireFox
            // 
            this.FireFox.AutoSize = true;
            this.FireFox.Location = new System.Drawing.Point(2, 25);
            this.FireFox.Margin = new System.Windows.Forms.Padding(2);
            this.FireFox.Name = "FireFox";
            this.FireFox.Size = new System.Drawing.Size(62, 19);
            this.FireFox.TabIndex = 26;
            this.FireFox.Text = "Firefox";
            this.FireFox.UseVisualStyleBackColor = true;
            this.FireFox.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Location = new System.Drawing.Point(236, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 273);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SoS Configurations";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.Privacy);
            this.panel2.Controls.Add(this.cleargpos);
            this.panel2.Controls.Add(this.removebloatware);
            this.panel2.Controls.Add(this.sysmon);
            this.panel2.Controls.Add(this.nessusPID);
            this.panel2.Controls.Add(this.sosbrowsers);
            this.panel2.Controls.Add(this.updatemanagement);
            this.panel2.Controls.Add(this.Mitigations);
            this.panel2.Controls.Add(this.installupdates);
            this.panel2.Controls.Add(this.ApplockerHardening);
            this.panel2.Controls.Add(this.diskcompression);
            this.panel2.Controls.Add(this.ImageCleanup);
            this.panel2.Controls.Add(this.BitlockerHardening);
            this.panel2.Controls.Add(this.deviceguard);
            this.panel2.Controls.Add(this.emet);
            this.panel2.Controls.Add(this.PSHardening);
            this.panel2.Controls.Add(this.disabletelemetry);
            this.panel2.Controls.Add(this.SMBHardening);
            this.panel2.Controls.Add(this.DefenderHardening);
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 249);
            this.panel2.TabIndex = 0;
            // 
            // Privacy
            // 
            this.Privacy.AutoSize = true;
            this.Privacy.Location = new System.Drawing.Point(211, 198);
            this.Privacy.Margin = new System.Windows.Forms.Padding(2);
            this.Privacy.Name = "Privacy";
            this.Privacy.Size = new System.Drawing.Size(146, 19);
            this.Privacy.TabIndex = 43;
            this.Privacy.Text = "Privacy Configurations";
            this.Privacy.UseVisualStyleBackColor = true;
            this.Privacy.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // cleargpos
            // 
            this.cleargpos.AutoSize = true;
            this.cleargpos.Location = new System.Drawing.Point(5, 2);
            this.cleargpos.Margin = new System.Windows.Forms.Padding(2);
            this.cleargpos.Name = "cleargpos";
            this.cleargpos.Size = new System.Drawing.Size(129, 19);
            this.cleargpos.TabIndex = 26;
            this.cleargpos.Text = "Clear Existing GPOs";
            this.cleargpos.UseVisualStyleBackColor = true;
            this.cleargpos.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // removebloatware
            // 
            this.removebloatware.AutoSize = true;
            this.removebloatware.Location = new System.Drawing.Point(211, 221);
            this.removebloatware.Margin = new System.Windows.Forms.Padding(2);
            this.removebloatware.Name = "removebloatware";
            this.removebloatware.Size = new System.Drawing.Size(124, 19);
            this.removebloatware.TabIndex = 44;
            this.removebloatware.Text = "Remove Bloatware";
            this.removebloatware.UseVisualStyleBackColor = true;
            this.removebloatware.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // sysmon
            // 
            this.sysmon.AutoSize = true;
            this.sysmon.Location = new System.Drawing.Point(211, 25);
            this.sysmon.Margin = new System.Windows.Forms.Padding(2);
            this.sysmon.Name = "sysmon";
            this.sysmon.Size = new System.Drawing.Size(150, 19);
            this.sysmon.TabIndex = 30;
            this.sysmon.Text = "Sysmon Configurations";
            this.sysmon.UseVisualStyleBackColor = true;
            this.sysmon.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // nessusPID
            // 
            this.nessusPID.AutoSize = true;
            this.nessusPID.Location = new System.Drawing.Point(211, 177);
            this.nessusPID.Margin = new System.Windows.Forms.Padding(2);
            this.nessusPID.Name = "nessusPID";
            this.nessusPID.Size = new System.Drawing.Size(117, 19);
            this.nessusPID.TabIndex = 42;
            this.nessusPID.Text = "Nessus PID 63155";
            this.nessusPID.UseVisualStyleBackColor = true;
            this.nessusPID.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // sosbrowsers
            // 
            this.sosbrowsers.AutoSize = true;
            this.sosbrowsers.Location = new System.Drawing.Point(211, 2);
            this.sosbrowsers.Margin = new System.Windows.Forms.Padding(2);
            this.sosbrowsers.Name = "sosbrowsers";
            this.sosbrowsers.Size = new System.Drawing.Size(150, 19);
            this.sosbrowsers.TabIndex = 29;
            this.sosbrowsers.Text = "Browser Configurations";
            this.sosbrowsers.UseVisualStyleBackColor = true;
            this.sosbrowsers.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // updatemanagement
            // 
            this.updatemanagement.AutoSize = true;
            this.updatemanagement.Location = new System.Drawing.Point(211, 48);
            this.updatemanagement.Margin = new System.Windows.Forms.Padding(2);
            this.updatemanagement.Name = "updatemanagement";
            this.updatemanagement.Size = new System.Drawing.Size(141, 19);
            this.updatemanagement.TabIndex = 31;
            this.updatemanagement.Text = "Update Optimizations";
            this.updatemanagement.UseVisualStyleBackColor = true;
            this.updatemanagement.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // Mitigations
            // 
            this.Mitigations.AutoSize = true;
            this.Mitigations.Location = new System.Drawing.Point(211, 154);
            this.Mitigations.Margin = new System.Windows.Forms.Padding(2);
            this.Mitigations.Name = "Mitigations";
            this.Mitigations.Size = new System.Drawing.Size(129, 19);
            this.Mitigations.TabIndex = 41;
            this.Mitigations.Text = "General Mitigations";
            this.Mitigations.UseVisualStyleBackColor = true;
            this.Mitigations.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // installupdates
            // 
            this.installupdates.AutoSize = true;
            this.installupdates.Location = new System.Drawing.Point(5, 48);
            this.installupdates.Margin = new System.Windows.Forms.Padding(2);
            this.installupdates.Name = "installupdates";
            this.installupdates.Size = new System.Drawing.Size(155, 19);
            this.installupdates.TabIndex = 28;
            this.installupdates.Text = "Install Windows Updates";
            this.installupdates.UseVisualStyleBackColor = true;
            this.installupdates.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // ApplockerHardening
            // 
            this.ApplockerHardening.AutoSize = true;
            this.ApplockerHardening.Location = new System.Drawing.Point(5, 83);
            this.ApplockerHardening.Margin = new System.Windows.Forms.Padding(2);
            this.ApplockerHardening.Name = "ApplockerHardening";
            this.ApplockerHardening.Size = new System.Drawing.Size(139, 19);
            this.ApplockerHardening.TabIndex = 32;
            this.ApplockerHardening.Text = "Applocker Hardening";
            this.ApplockerHardening.UseVisualStyleBackColor = true;
            this.ApplockerHardening.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // diskcompression
            // 
            this.diskcompression.AutoSize = true;
            this.diskcompression.Location = new System.Drawing.Point(211, 131);
            this.diskcompression.Margin = new System.Windows.Forms.Padding(2);
            this.diskcompression.Name = "diskcompression";
            this.diskcompression.Size = new System.Drawing.Size(159, 19);
            this.diskcompression.TabIndex = 40;
            this.diskcompression.Text = "Enable Disk Compression";
            this.diskcompression.UseVisualStyleBackColor = true;
            this.diskcompression.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // ImageCleanup
            // 
            this.ImageCleanup.AutoSize = true;
            this.ImageCleanup.Location = new System.Drawing.Point(5, 25);
            this.ImageCleanup.Margin = new System.Windows.Forms.Padding(2);
            this.ImageCleanup.Name = "ImageCleanup";
            this.ImageCleanup.Size = new System.Drawing.Size(106, 19);
            this.ImageCleanup.TabIndex = 27;
            this.ImageCleanup.Text = "Image Cleanup";
            this.ImageCleanup.UseVisualStyleBackColor = true;
            this.ImageCleanup.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // BitlockerHardening
            // 
            this.BitlockerHardening.AutoSize = true;
            this.BitlockerHardening.Location = new System.Drawing.Point(5, 106);
            this.BitlockerHardening.Margin = new System.Windows.Forms.Padding(2);
            this.BitlockerHardening.Name = "BitlockerHardening";
            this.BitlockerHardening.Size = new System.Drawing.Size(131, 19);
            this.BitlockerHardening.TabIndex = 33;
            this.BitlockerHardening.Text = "Bitlocker Hardening";
            this.BitlockerHardening.UseVisualStyleBackColor = true;
            this.BitlockerHardening.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // deviceguard
            // 
            this.deviceguard.AutoSize = true;
            this.deviceguard.Location = new System.Drawing.Point(211, 108);
            this.deviceguard.Margin = new System.Windows.Forms.Padding(2);
            this.deviceguard.Name = "deviceguard";
            this.deviceguard.Size = new System.Drawing.Size(134, 19);
            this.deviceguard.TabIndex = 39;
            this.deviceguard.Text = "Enable Device Guard";
            this.deviceguard.UseVisualStyleBackColor = true;
            this.deviceguard.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // emet
            // 
            this.emet.AutoSize = true;
            this.emet.Location = new System.Drawing.Point(5, 129);
            this.emet.Margin = new System.Windows.Forms.Padding(2);
            this.emet.Name = "emet";
            this.emet.Size = new System.Drawing.Size(114, 19);
            this.emet.TabIndex = 34;
            this.emet.Text = "EMET Hardening";
            this.emet.UseVisualStyleBackColor = true;
            this.emet.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // PSHardening
            // 
            this.PSHardening.AutoSize = true;
            this.PSHardening.Location = new System.Drawing.Point(5, 152);
            this.PSHardening.Margin = new System.Windows.Forms.Padding(2);
            this.PSHardening.Name = "PSHardening";
            this.PSHardening.Size = new System.Drawing.Size(142, 19);
            this.PSHardening.TabIndex = 35;
            this.PSHardening.Text = "Powershell Hardening";
            this.PSHardening.UseVisualStyleBackColor = true;
            this.PSHardening.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // disabletelemetry
            // 
            this.disabletelemetry.AutoSize = true;
            this.disabletelemetry.Location = new System.Drawing.Point(211, 85);
            this.disabletelemetry.Margin = new System.Windows.Forms.Padding(2);
            this.disabletelemetry.Name = "disabletelemetry";
            this.disabletelemetry.Size = new System.Drawing.Size(118, 19);
            this.disabletelemetry.TabIndex = 38;
            this.disabletelemetry.Text = "Disable Telemetry";
            this.disabletelemetry.UseVisualStyleBackColor = true;
            this.disabletelemetry.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // SMBHardening
            // 
            this.SMBHardening.AutoSize = true;
            this.SMBHardening.Location = new System.Drawing.Point(5, 175);
            this.SMBHardening.Margin = new System.Windows.Forms.Padding(2);
            this.SMBHardening.Name = "SMBHardening";
            this.SMBHardening.Size = new System.Drawing.Size(109, 19);
            this.SMBHardening.TabIndex = 36;
            this.SMBHardening.Text = "SMB Hardening";
            this.SMBHardening.UseVisualStyleBackColor = true;
            this.SMBHardening.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // DefenderHardening
            // 
            this.DefenderHardening.AutoSize = true;
            this.DefenderHardening.Location = new System.Drawing.Point(5, 198);
            this.DefenderHardening.Margin = new System.Windows.Forms.Padding(2);
            this.DefenderHardening.Name = "DefenderHardening";
            this.DefenderHardening.Size = new System.Drawing.Size(185, 19);
            this.DefenderHardening.TabIndex = 37;
            this.DefenderHardening.Text = "Windows Defender Hardening";
            this.DefenderHardening.UseVisualStyleBackColor = true;
            this.DefenderHardening.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // CheckAllBx
            // 
            this.CheckAllBx.AutoSize = true;
            this.CheckAllBx.Location = new System.Drawing.Point(487, 336);
            this.CheckAllBx.Name = "CheckAllBx";
            this.CheckAllBx.Size = new System.Drawing.Size(133, 19);
            this.CheckAllBx.TabIndex = 28;
            this.CheckAllBx.Text = "Check / Uncheck All";
            this.CheckAllBx.UseVisualStyleBackColor = true;
            this.CheckAllBx.CheckedChanged += new System.EventHandler(this.CheckAllBx_CheckedChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 377);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(608, 337);
            this.richTextBox1.TabIndex = 29;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 798);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.CheckAllBx);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.titlelabel);
            this.Controls.Add(this.stopbutton);
            this.Controls.Add(this.commandoutputlabel);
            this.Controls.Add(this.copyrightlabel);
            this.Controls.Add(this.Executebutton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Windows Optimize Harden Debloat";
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button Executebutton1;
        private Label copyrightlabel;
        private Label commandoutputlabel;
        private Button stopbutton;
        private Label titlelabel;
        private CheckBox Adobe;
        private GroupBox groupBox1;
        private Panel panel1;
        private CheckBox OneDrive;
        private CheckBox Office;
        private CheckBox Firewall;
        private CheckBox Windows;
        private CheckBox Java;
        private CheckBox DotNet;
        private CheckBox Edge;
        private CheckBox IE11;
        private CheckBox Chrome;
        private CheckBox FireFox;
        private GroupBox groupBox2;
        private CheckBox cleargpos;
        private CheckBox Defender;
        private CheckBox Privacy;
        private CheckBox nessusPID;
        private CheckBox Mitigations;
        private CheckBox diskcompression;
        private CheckBox deviceguard;
        private CheckBox disabletelemetry;
        private CheckBox DefenderHardening;
        private CheckBox SMBHardening;
        private CheckBox PSHardening;
        private CheckBox emet;
        private CheckBox BitlockerHardening;
        private CheckBox ApplockerHardening;
        private CheckBox updatemanagement;
        private CheckBox sysmon;
        private CheckBox sosbrowsers;
        private CheckBox installupdates;
        private CheckBox ImageCleanup;
        private CheckBox removebloatware;
        private Panel panel2;
        private CheckBox CheckAllBx;
        private RichTextBox richTextBox1;
    }
}