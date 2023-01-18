using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.VisualStyles;
using System.Text;
using System;

namespace Windows_Optimize_Harden_Debloat
{
    public partial class Form1 : Form
    {
        Dictionary<string,bool> CommandParameters = new Dictionary<string,bool>();

        public Form1()
        {
            InitializeComponent();
            CheckAllBx.Checked = true;
        }

        private void Executebutton1_Click(object sender, EventArgs e)
        {
            Executebutton1.Enabled = false;
            stopbutton.Enabled = true;
            _stopRequested = false;

            string command = string.Join(" ", CommandParameters.Select(kvp => $"-{kvp.Key} {(kvp.Value ? "$True" : "$False")}"));

            //$"\"-Adobe {Adobe} -FireFox {FireFox} -Chrome {Chrome}" +
            //$" -IE11 {IE11} -Edge {Edge} -DotNet {DotNet} -Office {Office}" +
            //$" -OneDrive {OneDrive} -Java {Java} -Windows {Windows}" +
            //$" -Defender {Defender} -Firewall {Firewall} -ClearGPOs {ClearGPOs}" +
            //$" -ImageCleanup {ImageCleanup} -WindowsUpdates {WindowsUpdates}" +
            //$" -ApplockerHardening {ApplockerHardening}" +
            //$" -BitlockerHardening {BitlockerHardening} -EMETHardening {EMETHardening}" +
            //$" -PowerShellHardening {PowerShellHardening} -SMBHardening {SMBHardening}" +
            //$" -SSLHardening {SSLHardening} -DefenderHardening {DefenderHardening}" +
            //$" -BrowserConfig {BrowserConfig} -SysmonConfig {SysmonConfig}" +
            //$" -UpdateOptimizations {UpdateOptimizations} -Telemetry {Telemetry}" +
            //$" -DeviceGuard {DeviceGuard} -Compression {Compression}" +
            //$" -Mitigations {Mitigations} -NessusPID {NessusPID} -Privacy {Privacy}" +
            //$" -Bloatware {Bloatware}\"";

            string script = ".\\sos-optimize-windows.ps1";
            string argument = $"-command {script} \"{command}\"";


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
                    StringBuilder sb = new StringBuilder();
                    while (!process.StandardOutput.EndOfStream)
                    {
                        int output = process.StandardOutput.Read();
                        if (!_stopRequested && richTextBox1.IsHandleCreated)
                        {
                            sb.Append((char)output);
                            this.Invoke(new Action(() =>
                            {
                                richTextBox1.AppendText(sb.ToString());
                                sb.Clear();
                            }));
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (!_stopRequested && richTextBox1.IsHandleCreated)
                    {
                        this.Invoke(new Action(() =>
                        {
                            richTextBox1.SelectionStart = richTextBox1.Text.Length;
                            richTextBox1.ScrollToCaret();
                        }));
                    }
                    process.WaitForExit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Executebutton1.Enabled = true;
                stopbutton.Enabled = false;
            }
        }

        private void Custom_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == null)
                return;

            string checkboxName = ((CheckBox)sender).Name;
            bool isChecked = ((CheckBox)sender).Checked;

            if (!CommandParameters.TryAdd(checkboxName, true))
            {
                CommandParameters[checkboxName] = isChecked;
            }
        }

        private void CheckAllBx_CheckedChanged(object sender, EventArgs e)
        {
            if(sender != null && sender is CheckBox toggleChecker)
            {
                foreach (var control in panel2.Controls)
                {
                    if (control is CheckBox aCheckbox)
                        aCheckbox.Checked = toggleChecker.Checked;
                }
                foreach (var control in panel1.Controls)
                {
                    if (control is CheckBox aCheckbox)
                        aCheckbox.Checked = toggleChecker.Checked;
                }
            }
            
        }
    }
}