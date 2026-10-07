namespace Windows_Optimize_Harden_Debloat;

partial class Form1
{
    private readonly FlowLayoutPanel optionPanel = new() { Dock = DockStyle.Fill, AutoScroll = true, FlowDirection = FlowDirection.TopDown, WrapContents = false };
    private readonly RichTextBox output = new() { Dock = DockStyle.Fill, ReadOnly = true };
    private readonly Button selectScript = new() { Text = "Select script", AutoSize = true };
    private readonly Button execute = new() { Text = "Preview and run", AutoSize = true, Enabled = false };
    private readonly Button stop = new() { Text = "Stop process", AutoSize = true, Enabled = false };
    private readonly Label scriptLabel = new() { Text = "Select sos-optimize-windows.ps1 from an extracted release.", AutoSize = true };

    private void InitializeComponent()
    {
        Text = "Windows configuration";
        ClientSize = new Size(920, 760);
        MinimumSize = new Size(700, 500);
        var layout = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 1, RowCount = 4, Padding = new Padding(12) };
        layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        layout.RowStyles.Add(new RowStyle(SizeType.Percent, 55));
        layout.RowStyles.Add(new RowStyle(SizeType.Percent, 45));
        layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        var toolbar = new FlowLayoutPanel { Dock = DockStyle.Fill, AutoSize = true };
        toolbar.Controls.AddRange(new Control[] { selectScript, execute, stop });
        layout.Controls.Add(scriptLabel, 0, 0);
        layout.Controls.Add(optionPanel, 0, 1);
        layout.Controls.Add(output, 0, 2);
        layout.Controls.Add(toolbar, 0, 3);
        Controls.Add(layout);
        selectScript.Click += SelectScript_Click;
        execute.Click += Execute_Click;
        stop.Click += Stop_Click;
        FormClosing += ClosingForm;
    }
}
