using ScottPlot.Plottables;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Management;
using System.Numerics;

namespace MicroscopeCellPoker
{
    public partial class frmMain : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public double IndenterCalibration { get; private set; } = 0.0D;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public double RawIndenterValue { get; private set; } = 0.0D;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public double IndenterForce { get; private set; } = 0.0D;

        private static SerialPort? IndenterSerialPort;
        private static SerialPort? StageSerialPort;

        private BackgroundWorker IndenterSerialPortBackgroundWorker = new BackgroundWorker();
        private BackgroundWorker StageSerialPortBackgroundWorker = new BackgroundWorker();

        DataLogger IndenterForceDataLogger = new DataLogger();
        DataLogger StageZPositionDataLogger = new DataLogger();

        private object StageSerialLockObject = new object();

        double[] StagePosition = new double[3] { 0, 0, 0 };

        private bool CollectData = false;
        StreamWriter? DataStreamWriter;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            PopulateCOMPortSelections();
            InitializePlotFunctions();
        }

        private void PopulateCOMPortSelections()
        {
            // From: https://stackoverflow.com/questions/2837985/getting-serial-port-information
            using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE Caption like '%(COM%'"))
            {
                var portNames = SerialPort.GetPortNames();
                var ports = searcher.Get().Cast<ManagementBaseObject>().ToList().Select(p => p["Caption"].ToString());

                var portList = portNames.Select(n => n + " - " + ports.FirstOrDefault(s => s.Contains(n))).ToList();

                foreach (string s in portList)
                {
                    cmbIndenterCOMPort.Items.Add(s.ToString());
                    cmbStageCOMPort.Items.Add(s.ToString());
                }
            }
        }

        private void InitializePlotFunctions()
        {
            tmrPlot.Start();

            IndenterForceDataLogger = pltMain.Plot.Add.DataLogger();
            StageZPositionDataLogger = pltMain.Plot.Add.DataLogger();
            this.pltMain.Plot.Axes.ContinuouslyAutoscale = true;
        }

        private void IndenterSerialPortBackgroundWorker_DoWork(object? sender, DoWorkEventArgs e)
        {
            if (IndenterSerialPort == null)
            {
                MessageBox.Show("Indenter Serial Port is not initialized.", "Error", MessageBoxButtons.OK);
                return;
            }

            List<byte> buffer = new List<byte>();
            while (true)
            {
                try
                {
                    int b = IndenterSerialPort.ReadByte();
                    if (b == -1) continue;

                    buffer.Add((byte)b);
                    if (buffer.Count > 16)
                        buffer.RemoveAt(0);
                    if (buffer.Count >= 4 && buffer[0] == 0x0D && buffer[1] == 0x0A)
                    {
                        ushort value = (ushort)(buffer[2] | (buffer[3] << 8));
                        this.RawIndenterValue = value;
                        this.IndenterForce = value / 100.0D - IndenterCalibration;
                    }
                }
                catch (TimeoutException ex)
                {
                    continue;
                }
            }
        }

        private void StageSerialPortBackgroundWorker_DoWork(object? sender, DoWorkEventArgs e)
        {
            if (StageSerialPort == null)
            {
                MessageBox.Show("Stage Serial Port is not initialized.", "Error", MessageBoxButtons.OK);
                return;
            }

            while (!StageSerialPortBackgroundWorker.CancellationPending)
            {
                try
                {
                    // Read the stage position
                    lock (StageSerialLockObject)
                    {
                        StageSerialPort.DiscardInBuffer();
                        StageSerialPort.DiscardOutBuffer();

                        // Get Position
                        StageSerialPort.Write("W X Y Z\r");

                        string posLine = StageSerialPort.ReadLine();
                        if (posLine.StartsWith(":A"))
                        {
                            posLine.Remove(0, 3);
                            string[] positions = posLine.Split(" "); // Is this better to do than just run the split command 3 times? Compiler optimization. Who knows. Whatever.
                            StagePosition[0] = double.Parse(positions[1]);
                            StagePosition[1] = double.Parse(positions[2]);
                            StagePosition[2] = double.Parse(positions[3]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    continue;
                }
            }
        }

        private void tmrPlot_Tick(object sender, EventArgs e)
        {
            if (IndenterSerialPort != null && IndenterSerialPort.IsOpen)
            {
                lblIndenterForce.Text = $"Indenter Force: {this.IndenterForce} mg";

                IndenterForceDataLogger.Add(this.IndenterForce);
                if (IndenterForceDataLogger.Data.Coordinates.Count > 1000)
                {
                    IndenterForceDataLogger.Data.Coordinates.RemoveRange(0, 1);
                }
            }

            if (StageSerialPort != null && StageSerialPort.IsOpen)
            {
                lblStageX.Text = "Stage X: " + StagePosition[0].ToString();
                lblStageY.Text = "Stage Y: " + StagePosition[1].ToString();
                lblStageZ.Text = "Stage Z: " + StagePosition[2].ToString();

                StageZPositionDataLogger.Add(this.StagePosition[2]); 
                if (StageZPositionDataLogger.Data.Coordinates.Count > 1000)
                {
                    StageZPositionDataLogger.Data.Coordinates.RemoveRange(0, 1);
                }
            }

            if (CollectData)
            {
                string data = $"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:ffff")}, {this.IndenterForce}, {this.StagePosition[2]}";
                DataStreamWriter.WriteLine(data);
            }

            pltMain.Refresh();
        }

        private void btnIndenterConnect_Click(object sender, EventArgs e)
        {
            IndenterSerialPort = new SerialPort(cmbIndenterCOMPort.Text.Split(" ")[0], 115200);
            IndenterSerialPort.ReadTimeout = 1000;
            IndenterSerialPort.WriteTimeout = 1000;
            IndenterSerialPort.Open();

            IndenterSerialPortBackgroundWorker = new BackgroundWorker();
            IndenterSerialPortBackgroundWorker.DoWork += IndenterSerialPortBackgroundWorker_DoWork;
            IndenterSerialPortBackgroundWorker.RunWorkerAsync();
        }

        private void btnStageConnect_Click(object sender, EventArgs e)
        {
            StageSerialPort = new SerialPort(cmbStageCOMPort.Text.Split(" ")[0], 9600);
            StageSerialPort.ReadTimeout = 1000;
            StageSerialPort.WriteTimeout = 1000;
            StageSerialPort.DtrEnable = false;
            StageSerialPort.RtsEnable = false;
            StageSerialPort.Open();

            StageSerialPortBackgroundWorker = new BackgroundWorker();
            StageSerialPortBackgroundWorker.DoWork += StageSerialPortBackgroundWorker_DoWork;
            StageSerialPortBackgroundWorker.RunWorkerAsync();
        }

        private void StageHalt()
        {
            if (StageSerialPort == null || !StageSerialPort.IsOpen) return;

            lock (StageSerialLockObject)
            {
                StageSerialPort.DiscardInBuffer();
                StageSerialPort.DiscardInBuffer();
                StageSerialPort.Write("\\");
            }
        }

        private void StageRun(int X, int Y, int Z) // Lazy
        {
            if (StageSerialPort == null || !StageSerialPort.IsOpen) return;

            lock (StageSerialLockObject)
            {
                int xDir = X * 9999999;
                int yDir = Y * 9999999;
                int zDir = Z * 9999999;

                StageSerialPort.DiscardInBuffer();
                StageSerialPort.DiscardInBuffer();
                StageSerialPort.Write($"R X={xDir} Y={yDir} Z={zDir}\r");
            }
        }

        private void btnStageCtrlRunYUp_MouseDown(object sender, MouseEventArgs e)
        {
            StageRun(0, 1, 0);
        }

        private void btnStageCtrlRunYDown_MouseUp(object sender, MouseEventArgs e)
        {
            StageRun(0, -1, 0);
        }

        private void btnStageCtrlRunXLeft_MouseDown(object sender, MouseEventArgs e)
        {
            StageRun(-1, 0, 0);
        }

        private void btnStageCtrlRunXRight_MouseDown(object sender, MouseEventArgs e)
        {
            StageRun(1, 0, 0);
        }
        private void btnStageCtrlRunZUp_MouseDown(object sender, MouseEventArgs e)
        {
            StageRun(0, 0, 1);
        }

        private void btnStageCtrlRunZDown_MouseDown(object sender, MouseEventArgs e)
        {
            StageRun(0, 0, -1);
        }

        private void btnStageCtrlRunXLeftYUp_MouseDown(object sender, MouseEventArgs e)
        {
            StageRun(-1, 1, 0);
        }

        private void btnStageCtrlRunXRightYUp_MouseDown(object sender, MouseEventArgs e)
        {
            StageRun(1, 1, 0);
        }

        private void btnStageCtrlRunXLeftYDown_MouseDown(object sender, MouseEventArgs e)
        {
            StageRun(-1, -1, 0);
        }

        private void btnStageCtrlRunXRightYDown_MouseDown(object sender, MouseEventArgs e)
        {
            StageRun(1, -1, 0);
        }

        private void btnStageCtrlRunXLeft_MouseUp(object sender, MouseEventArgs e)
        {
            StageHalt();
        }

        private void btnStageCtrlRunXRight_MouseUp(object sender, MouseEventArgs e)
        {
            StageHalt();
        }

        private void btnStageCtrlRunZUp_MouseUp(object sender, MouseEventArgs e)
        {
            StageHalt();
        }

        private void btnStageCtrlRunZDown_MouseUp(object sender, MouseEventArgs e)
        {
            StageHalt();
        }

        private void btnStageCtrlRunYUp_MouseUp(object sender, MouseEventArgs e)
        {
            StageHalt();
        }

        private void btnStageCtrlRunYDown_MouseDown(object sender, MouseEventArgs e)
        {
            StageHalt();
        }

        private void btnStageCtrlHalt_Click(object sender, EventArgs e)
        {
            StageHalt();
        }

        private void btnStageCtrlAbsoluteMove_Click(object sender, EventArgs e)
        {
            if (StageSerialPort == null || !StageSerialPort.IsOpen) return;

            lock (StageSerialLockObject)
            {
                StageSerialPort.DiscardInBuffer();
                StageSerialPort.DiscardInBuffer();
                StageSerialPort.Write($"M X={numStageCtrlAbsRelXum.Value} Y={numStageCtrlAbsRelXum.Value} Z={numStageCtrlAbsRelXum.Value}\r");
            }
        }

        private void btnStageCtrlRelativeMove_Click(object sender, EventArgs e)
        {
            if (StageSerialPort == null || !StageSerialPort.IsOpen) return;

            lock (StageSerialLockObject)
            {
                StageSerialPort.DiscardInBuffer();
                StageSerialPort.DiscardInBuffer();
                StageSerialPort.Write($"R X={numStageCtrlAbsRelXum.Value} Y={numStageCtrlAbsRelXum.Value} Z={numStageCtrlAbsRelXum.Value}\r");
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (StageSerialPort == null || !StageSerialPort.IsOpen) return;

            lock (StageSerialLockObject)
            {
                StageSerialPort.DiscardInBuffer();
                StageSerialPort.DiscardInBuffer();
                StageSerialPort.Write("R X=0 Y=0 Z=0\r");
            }
        }

        private void btnIndenterCalibrate_Click(object sender, EventArgs e)
        {
            this.IndenterCalibration = (double)numIndenterCalibration.Value;
        }

        private void btnDataSelectDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select a directory to save data files.";
            fbd.ShowNewFolderButton = true;

            if (txtDataDirectory.Text != string.Empty && Directory.Exists(txtDataDirectory.Text))
            {
                fbd.SelectedPath = txtDataDirectory.Text;
            }
            else
            {
                fbd.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            }

            fbd.RootFolder = Environment.SpecialFolder.MyDocuments;

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtDataDirectory.Text = fbd.SelectedPath;
            }
        }

        private void btnDataToggleCollection_Click(object sender, EventArgs e)
        {
            if (CollectData == false)
            {
                if (!Directory.Exists(txtDataDirectory.Text))
                {
                    return;
                }
                if (txtDataFileName.Text.IndexOfAny(Path.GetInvalidFileNameChars()) > 0)
                {
                    return;
                }

                DataStreamWriter = File.AppendText(Path.Combine(txtDataDirectory.Text, txtDataFileName.Text + ".csv"));
                CollectData = true;
                btnDataToggleCollection.Text = "Stop Data Collection";
            }
            else
            {
                if (DataStreamWriter != null)
                {
                    DataStreamWriter.Flush();
                    DataStreamWriter.Close();
                }
                CollectData = false;
                btnDataToggleCollection.Text = "Start Data Collection";
            }
        }
    }
}
