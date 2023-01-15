using System.Diagnostics;

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
        }
        private void Executebutton1_Click(object sender, EventArgs e)
        {
            Executebutton1.Enabled = false;
            stopbutton.Enabled = true;
            string command = GenerateCommand();
            _currentThread = new Thread(() => RunCommand(command));
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

        private void RunCommand(string command)
        {
            try
            {
                using (Process process = new Process())
                {
                    process.StartInfo.FileName = "powershell.exe";
                    process.StartInfo.Arguments = "-Command " + command;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.CreateNoWindow = true;
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

        private string GenerateCommand()
        {
            return "Get-Location";
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