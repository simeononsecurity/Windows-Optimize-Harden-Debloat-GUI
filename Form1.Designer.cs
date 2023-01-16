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
            this.commandoutputbox = new System.Windows.Forms.TextBox();
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
            this.Firefox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Privacy = new System.Windows.Forms.CheckBox();
            this.ClearGPOs = new System.Windows.Forms.CheckBox();
            this.Bloatware = new System.Windows.Forms.CheckBox();
            this.SysmonConfig = new System.Windows.Forms.CheckBox();
            this.NessusPID = new System.Windows.Forms.CheckBox();
            this.BrowserConfig = new System.Windows.Forms.CheckBox();
            this.UpdateOptimizations = new System.Windows.Forms.CheckBox();
            this.Mitigations = new System.Windows.Forms.CheckBox();
            this.WindowsUpdates = new System.Windows.Forms.CheckBox();
            this.ApplockerHardening = new System.Windows.Forms.CheckBox();
            this.Compression = new System.Windows.Forms.CheckBox();
            this.ImageCleanup = new System.Windows.Forms.CheckBox();
            this.BitlockerHardening = new System.Windows.Forms.CheckBox();
            this.DeviceGuard = new System.Windows.Forms.CheckBox();
            this.EMETHardening = new System.Windows.Forms.CheckBox();
            this.PowerShellHardening = new System.Windows.Forms.CheckBox();
            this.Telemetry = new System.Windows.Forms.CheckBox();
            this.SMBHardening = new System.Windows.Forms.CheckBox();
            this.DefenderHardening = new System.Windows.Forms.CheckBox();
            this.CheckAllBx = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Executebutton1
            // 
            this.Executebutton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Executebutton1.Location = new System.Drawing.Point(463, 706);
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
            this.copyrightlabel.Location = new System.Drawing.Point(12, 759);
            this.copyrightlabel.Name = "copyrightlabel";
            this.copyrightlabel.Size = new System.Drawing.Size(146, 15);
            this.copyrightlabel.TabIndex = 16;
            this.copyrightlabel.Text = "© SimeonOnSecurity 2023";
            // 
            // commandoutputbox
            // 
            this.commandoutputbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commandoutputbox.Location = new System.Drawing.Point(9, 377);
            this.commandoutputbox.Multiline = true;
            this.commandoutputbox.Name = "commandoutputbox";
            this.commandoutputbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.commandoutputbox.Size = new System.Drawing.Size(619, 318);
            this.commandoutputbox.TabIndex = 17;
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
            this.stopbutton.Location = new System.Drawing.Point(282, 705);
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
            this.panel1.Controls.Add(this.Firefox);
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
            // Firefox
            // 
            this.Firefox.AutoSize = true;
            this.Firefox.Location = new System.Drawing.Point(2, 25);
            this.Firefox.Margin = new System.Windows.Forms.Padding(2);
            this.Firefox.Name = "Firefox";
            this.Firefox.Size = new System.Drawing.Size(62, 19);
            this.Firefox.TabIndex = 26;
            this.Firefox.Text = "Firefox";
            this.Firefox.UseVisualStyleBackColor = true;
            this.Firefox.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
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
            this.panel2.Controls.Add(this.ClearGPOs);
            this.panel2.Controls.Add(this.Bloatware);
            this.panel2.Controls.Add(this.SysmonConfig);
            this.panel2.Controls.Add(this.NessusPID);
            this.panel2.Controls.Add(this.BrowserConfig);
            this.panel2.Controls.Add(this.UpdateOptimizations);
            this.panel2.Controls.Add(this.Mitigations);
            this.panel2.Controls.Add(this.WindowsUpdates);
            this.panel2.Controls.Add(this.ApplockerHardening);
            this.panel2.Controls.Add(this.Compression);
            this.panel2.Controls.Add(this.ImageCleanup);
            this.panel2.Controls.Add(this.BitlockerHardening);
            this.panel2.Controls.Add(this.DeviceGuard);
            this.panel2.Controls.Add(this.EMETHardening);
            this.panel2.Controls.Add(this.PowerShellHardening);
            this.panel2.Controls.Add(this.Telemetry);
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
            // ClearGPOs
            // 
            this.ClearGPOs.AutoSize = true;
            this.ClearGPOs.Location = new System.Drawing.Point(5, 2);
            this.ClearGPOs.Margin = new System.Windows.Forms.Padding(2);
            this.ClearGPOs.Name = "ClearGPOs";
            this.ClearGPOs.Size = new System.Drawing.Size(129, 19);
            this.ClearGPOs.TabIndex = 26;
            this.ClearGPOs.Text = "Clear Existing GPOs";
            this.ClearGPOs.UseVisualStyleBackColor = true;
            this.ClearGPOs.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // Bloatware
            // 
            this.Bloatware.AutoSize = true;
            this.Bloatware.Location = new System.Drawing.Point(211, 221);
            this.Bloatware.Margin = new System.Windows.Forms.Padding(2);
            this.Bloatware.Name = "Bloatware";
            this.Bloatware.Size = new System.Drawing.Size(124, 19);
            this.Bloatware.TabIndex = 44;
            this.Bloatware.Text = "Remove Bloatware";
            this.Bloatware.UseVisualStyleBackColor = true;
            this.Bloatware.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // SysmonConfig
            // 
            this.SysmonConfig.AutoSize = true;
            this.SysmonConfig.Location = new System.Drawing.Point(211, 25);
            this.SysmonConfig.Margin = new System.Windows.Forms.Padding(2);
            this.SysmonConfig.Name = "SysmonConfig";
            this.SysmonConfig.Size = new System.Drawing.Size(150, 19);
            this.SysmonConfig.TabIndex = 30;
            this.SysmonConfig.Text = "Sysmon Configurations";
            this.SysmonConfig.UseVisualStyleBackColor = true;
            this.SysmonConfig.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // NessusPID
            // 
            this.NessusPID.AutoSize = true;
            this.NessusPID.Location = new System.Drawing.Point(211, 177);
            this.NessusPID.Margin = new System.Windows.Forms.Padding(2);
            this.NessusPID.Name = "NessusPID";
            this.NessusPID.Size = new System.Drawing.Size(117, 19);
            this.NessusPID.TabIndex = 42;
            this.NessusPID.Text = "Nessus PID 63155";
            this.NessusPID.UseVisualStyleBackColor = true;
            this.NessusPID.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // BrowserConfig
            // 
            this.BrowserConfig.AutoSize = true;
            this.BrowserConfig.Location = new System.Drawing.Point(211, 2);
            this.BrowserConfig.Margin = new System.Windows.Forms.Padding(2);
            this.BrowserConfig.Name = "BrowserConfig";
            this.BrowserConfig.Size = new System.Drawing.Size(150, 19);
            this.BrowserConfig.TabIndex = 29;
            this.BrowserConfig.Text = "Browser Configurations";
            this.BrowserConfig.UseVisualStyleBackColor = true;
            this.BrowserConfig.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // UpdateOptimizations
            // 
            this.UpdateOptimizations.AutoSize = true;
            this.UpdateOptimizations.Location = new System.Drawing.Point(211, 48);
            this.UpdateOptimizations.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateOptimizations.Name = "UpdateOptimizations";
            this.UpdateOptimizations.Size = new System.Drawing.Size(141, 19);
            this.UpdateOptimizations.TabIndex = 31;
            this.UpdateOptimizations.Text = "Update Optimizations";
            this.UpdateOptimizations.UseVisualStyleBackColor = true;
            this.UpdateOptimizations.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
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
            // WindowsUpdates
            // 
            this.WindowsUpdates.AutoSize = true;
            this.WindowsUpdates.Location = new System.Drawing.Point(5, 48);
            this.WindowsUpdates.Margin = new System.Windows.Forms.Padding(2);
            this.WindowsUpdates.Name = "WindowsUpdates";
            this.WindowsUpdates.Size = new System.Drawing.Size(155, 19);
            this.WindowsUpdates.TabIndex = 28;
            this.WindowsUpdates.Text = "Install Windows Updates";
            this.WindowsUpdates.UseVisualStyleBackColor = true;
            this.WindowsUpdates.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
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
            // Compression
            // 
            this.Compression.AutoSize = true;
            this.Compression.Location = new System.Drawing.Point(211, 131);
            this.Compression.Margin = new System.Windows.Forms.Padding(2);
            this.Compression.Name = "Compression";
            this.Compression.Size = new System.Drawing.Size(159, 19);
            this.Compression.TabIndex = 40;
            this.Compression.Text = "Enable Disk Compression";
            this.Compression.UseVisualStyleBackColor = true;
            this.Compression.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
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
            // DeviceGuard
            // 
            this.DeviceGuard.AutoSize = true;
            this.DeviceGuard.Location = new System.Drawing.Point(211, 108);
            this.DeviceGuard.Margin = new System.Windows.Forms.Padding(2);
            this.DeviceGuard.Name = "DeviceGuard";
            this.DeviceGuard.Size = new System.Drawing.Size(134, 19);
            this.DeviceGuard.TabIndex = 39;
            this.DeviceGuard.Text = "Enable Device Guard";
            this.DeviceGuard.UseVisualStyleBackColor = true;
            this.DeviceGuard.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // EMETHardening
            // 
            this.EMETHardening.AutoSize = true;
            this.EMETHardening.Location = new System.Drawing.Point(5, 129);
            this.EMETHardening.Margin = new System.Windows.Forms.Padding(2);
            this.EMETHardening.Name = "EMETHardening";
            this.EMETHardening.Size = new System.Drawing.Size(114, 19);
            this.EMETHardening.TabIndex = 34;
            this.EMETHardening.Text = "EMET Hardening";
            this.EMETHardening.UseVisualStyleBackColor = true;
            this.EMETHardening.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // PowerShellHardening
            // 
            this.PowerShellHardening.AutoSize = true;
            this.PowerShellHardening.Location = new System.Drawing.Point(5, 152);
            this.PowerShellHardening.Margin = new System.Windows.Forms.Padding(2);
            this.PowerShellHardening.Name = "PowerShellHardening";
            this.PowerShellHardening.Size = new System.Drawing.Size(142, 19);
            this.PowerShellHardening.TabIndex = 35;
            this.PowerShellHardening.Text = "Powershell Hardening";
            this.PowerShellHardening.UseVisualStyleBackColor = true;
            this.PowerShellHardening.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // Telemetry
            // 
            this.Telemetry.AutoSize = true;
            this.Telemetry.Location = new System.Drawing.Point(211, 85);
            this.Telemetry.Margin = new System.Windows.Forms.Padding(2);
            this.Telemetry.Name = "Telemetry";
            this.Telemetry.Size = new System.Drawing.Size(118, 19);
            this.Telemetry.TabIndex = 38;
            this.Telemetry.Text = "Disable Telemetry";
            this.Telemetry.UseVisualStyleBackColor = true;
            this.Telemetry.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 783);
            this.Controls.Add(this.CheckAllBx);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.titlelabel);
            this.Controls.Add(this.stopbutton);
            this.Controls.Add(this.commandoutputlabel);
            this.Controls.Add(this.commandoutputbox);
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
        private TextBox commandoutputbox;
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
        private CheckBox Firefox;
        private GroupBox groupBox2;
        private CheckBox ClearGPOs;
        private CheckBox Defender;
        private CheckBox Privacy;
        private CheckBox NessusPID;
        private CheckBox Mitigations;
        private CheckBox Compression;
        private CheckBox DeviceGuard;
        private CheckBox Telemetry;
        private CheckBox DefenderHardening;
        private CheckBox SMBHardening;
        private CheckBox PowerShellHardening;
        private CheckBox EMETHardening;
        private CheckBox BitlockerHardening;
        private CheckBox ApplockerHardening;
        private CheckBox UpdateOptimizations;
        private CheckBox SysmonConfig;
        private CheckBox BrowserConfig;
        private CheckBox WindowsUpdates;
        private CheckBox ImageCleanup;
        private CheckBox Bloatware;
        private Panel panel2;
        private CheckBox CheckAllBx;
    }
}