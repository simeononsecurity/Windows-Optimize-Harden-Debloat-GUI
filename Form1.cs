using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.VisualStyles;

namespace Windows_Optimize_Harden_Debloat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            stopbutton.Enabled = false;
            for (int i = 0; i < STIGscheckedListBox1.Items.Count; i++)
            {
                STIGscheckedListBox1.SetItemChecked(i, true);
            }
            for (int i = 0; i < SoScheckedListBox1.Items.Count; i++)
            {
                SoScheckedListBox1.SetItemChecked(i, true);
            }
            for (int i = 0; i < SoScheckedListBox2.Items.Count; i++)
            {
                SoScheckedListBox2.SetItemChecked(i, true);
            }
            for (int i = 0; i < SoScheckedListBox3.Items.Count; i++)
            {
                SoScheckedListBox3.SetItemChecked(i, true);
            }
            for (int i = 0; i < SoScheckedListBox4.Items.Count; i++)
            {
                SoScheckedListBox4.SetItemChecked(i, true);
            }
        }

        private ItemChecked[] GetCheckedItems(CheckedListBox list)
        {
            ItemChecked[] items = new ItemChecked[list.Items.Count];
            for (int i = 0; i < list.Items.Count; i++)
            {
                items[i] = new ItemChecked() { Name = list.Items[i].ToString(), Checked = list.GetItemChecked(i) };
            }
            return items;
        }

        private class ItemChecked
        {
            public string Name { get; set; }
            public bool Checked { get; set; }
        }


        private void Executebutton1_Click(object sender, EventArgs e)
        {
            Executebutton1.Enabled = false;
            stopbutton.Enabled = true;
            _stopRequested = false;

            ItemChecked[] STIGscheckedListBox1_item = GetCheckedItems(STIGscheckedListBox1);
            ItemChecked[] SoScheckedListBox1_item = GetCheckedItems(SoScheckedListBox1);
            ItemChecked[] SoScheckedListBox2_item = GetCheckedItems(SoScheckedListBox2);
            ItemChecked[] SoScheckedListBox3_item = GetCheckedItems(SoScheckedListBox3);
            ItemChecked[] SoScheckedListBox4_item = GetCheckedItems(SoScheckedListBox4);

            string Adobe = STIGscheckedListBox1_item[0].Checked ? "$True" : "$False";
            string FireFox = STIGscheckedListBox1_item[1].Checked ? "$True" : "$False";
            string Chrome = STIGscheckedListBox1_item[2].Checked ? "$True" : "$False";
            string IE11 = STIGscheckedListBox1_item[3].Checked ? "$True" : "$False";
            string Edge = STIGscheckedListBox1_item[4].Checked ? "$True" : "$False";
            string DotNet = STIGscheckedListBox1_item[5].Checked ? "$True" : "$False";
            string Office = STIGscheckedListBox1_item[6].Checked ? "$True" : "$False";
            string OneDrive = STIGscheckedListBox1_item[7].Checked ? "$True" : "$False";
            string Java = STIGscheckedListBox1_item[8].Checked ? "$True" : "$False";
            string Windows = STIGscheckedListBox1_item[9].Checked ? "$True" : "$False";
            string Defender = STIGscheckedListBox1_item[10].Checked ? "$True" : "$False";
            string Firewall = STIGscheckedListBox1_item[11].Checked ? "$True" : "$False";

            string ClearGPOs = SoScheckedListBox1_item[0].Checked ? "$True" : "$False";
            string ImageCleanup = SoScheckedListBox1_item[1].Checked ? "$True" : "$False";
            string WindowsUpdates = SoScheckedListBox1_item[2].Checked ? "$True" : "$False";

            string ApplockerHardening = SoScheckedListBox2_item[0].Checked ? "$True" : "$False";
            string BitlockerHardening = SoScheckedListBox2_item[1].Checked ? "$True" : "$False";
            string EMETHardening = SoScheckedListBox2_item[2].Checked ? "$True" : "$False";
            string PowerShellHardening = SoScheckedListBox2_item[3].Checked ? "$True" : "$False";
            string SMBHardening = SoScheckedListBox2_item[4].Checked ? "$True" : "$False";
            string SSLHardening = SoScheckedListBox2_item[5].Checked ? "$True" : "$False";
            string DefenderHardening = SoScheckedListBox2_item[6].Checked ? "$True" : "$False";

            string BrowserConfig = SoScheckedListBox3_item[0].Checked ? "$True" : "$False";
            string SysmonConfig = SoScheckedListBox3_item[1].Checked ? "$True" : "$False";
            string UpdateOptimizations = SoScheckedListBox3_item[2].Checked ? "$True" : "$False";

            string Telemetry = SoScheckedListBox4_item[0].Checked ? "$True" : "$False";
            string DeviceGuard = SoScheckedListBox4_item[1].Checked ? "$True" : "$False";
            string Compression = SoScheckedListBox4_item[2].Checked ? "$True" : "$False";
            string Mitigations = SoScheckedListBox4_item[3].Checked ? "$True" : "$False";
            string NessusPID = SoScheckedListBox4_item[4].Checked ? "$True" : "$False";
            string Privacy = SoScheckedListBox4_item[5].Checked ? "$True" : "$False";
            string Bloatware = SoScheckedListBox4_item[6].Checked ? "$True" : "$False";

            string command = $"-Adobe {Adobe} -FireFox {FireFox} -Chrome {Chrome} -IE11 {IE11} -Edge {Edge} -DotNet {DotNet} -Office {Office} -OneDrive {OneDrive} -Java {Java} -Windows {Windows} -Defender {Defender} -Firewall {Firewall} -ClearGPOs {ClearGPOs} -ImageCleanup {ImageCleanup} -WindowsUpdates {WindowsUpdates} -ApplockerHardening {ApplockerHardening} -BitlockerHardening {BitlockerHardening} -EMETHardening {EMETHardening} -PowerShellHardening {PowerShellHardening} -SMBHardening {SMBHardening} -SSLHardening {SSLHardening} -DefenderHardening {DefenderHardening} -BrowserConfig {BrowserConfig} -SysmonConfig {SysmonConfig} -UpdateOptimizations {UpdateOptimizations} -Telemetry {Telemetry} -DeviceGuard {DeviceGuard} -Compression {Compression} -Mitigations {Mitigations} -NessusPID {NessusPID} -Privacy {Privacy} -Bloatware {Bloatware}";
            string script = ".\\sos-optimize-windows.ps1";
            string argument = $"-File {script} {command}";


            _currentThread = new Thread(() => RunCommand(argument));
            _currentThread.Start();
            _stopRequested = false;
        }

        private Thread _currentThread;
        private bool _stopRequested = false;

        private void stopbutton_Click(object sender, EventArgs e)
        {
            _stopRequested = true;
            Executebutton1.Enabled = true;
            stopbutton.Enabled = false;
        }
        private void RunCommand(string argument)
        {
            try
            {
                using (Process process = new Process())
                {
                    process.StartInfo.FileName = "powershell.exe";
                    process.StartInfo.Arguments = argument;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.CreateNoWindow = true;
                    process.StartInfo.Verb = "runas";
                    process.Start();
                    while (!process.StandardOutput.EndOfStream)
                    {
                        string output = process.StandardOutput.ReadLine();
                        if (!_stopRequested)
                        {
                            this.Invoke(new Action(() =>
                            {
                                commandoutputbox.AppendText(output + Environment.NewLine);
                            }));
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (!_stopRequested)
                    {
                        this.Invoke(new Action(() =>
                        {
                            commandoutputbox.SelectionStart = commandoutputbox.Text.Length;
                            commandoutputbox.ScrollToCaret();
                        }));
                    }
                    process.WaitForExit();
                    Invoke(new Action(() => Executebutton1.Enabled = true));
                    Invoke(new Action(() => stopbutton.Enabled = false));
                }
            }
            catch (ThreadAbortException)
            {
                // code to handle thread stop
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}