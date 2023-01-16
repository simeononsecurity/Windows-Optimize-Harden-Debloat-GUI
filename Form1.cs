using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.VisualStyles;

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

            string command = string.Join(' ', CommandParameters.Select(kvp => $"-{kvp.Key} {(kvp.Value ? "$True" : "$False")}"));

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