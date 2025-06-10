namespace MicroscopeCellPoker
{
    partial class frmMain
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
            components = new System.ComponentModel.Container();
            pltMain = new ScottPlot.WinForms.FormsPlot();
            tmrPlot = new System.Windows.Forms.Timer(components);
            lblIndenterForce = new Label();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            btnIndenterConnect = new Button();
            label1 = new Label();
            cmbIndenterCOMPort = new ComboBox();
            groupBox5 = new GroupBox();
            label5 = new Label();
            numIndenterCalibration = new NumericUpDown();
            label4 = new Label();
            btnIndenterCalibrate = new Button();
            groupBox2 = new GroupBox();
            groupBox6 = new GroupBox();
            btnHome = new Button();
            btnStageCtrlHalt = new Button();
            groupBox8 = new GroupBox();
            btnStageCtrlRelativeMove = new Button();
            btnStageCtrlAbsoluteMove = new Button();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            numStageCtrlAbsRelZum = new NumericUpDown();
            label7 = new Label();
            numStageCtrlAbsRelYum = new NumericUpDown();
            label6 = new Label();
            numStageCtrlAbsRelXum = new NumericUpDown();
            groupBox7 = new GroupBox();
            btnStageCtrlRunXRightYUp = new Button();
            btnStageCtrlRunXRightYDown = new Button();
            btnStageCtrlRunXLeftYDown = new Button();
            btnStageCtrlRunXLeftYUp = new Button();
            btnStageCtrlRunZDown = new Button();
            btnStageCtrlRunZUp = new Button();
            btnStageCtrlRunYDown = new Button();
            btnStageCtrlRunXRight = new Button();
            btnStageCtrlRunXLeft = new Button();
            btnStageCtrlRunYUp = new Button();
            groupBox4 = new GroupBox();
            btnStageConnect = new Button();
            label2 = new Label();
            cmbStageCOMPort = new ComboBox();
            label3 = new Label();
            lblStageX = new Label();
            lblStageY = new Label();
            lblStageZ = new Label();
            groupBox9 = new GroupBox();
            groupBox10 = new GroupBox();
            btnDataSetSampleData = new Button();
            label14 = new Label();
            txtDataSampleData = new TextBox();
            btnDataToggleCollection = new Button();
            btnDataSelectDirectory = new Button();
            txtDataFileName = new TextBox();
            txtDataDirectory = new TextBox();
            label13 = new Label();
            label12 = new Label();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numIndenterCalibration).BeginInit();
            groupBox2.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numStageCtrlAbsRelZum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStageCtrlAbsRelYum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStageCtrlAbsRelXum).BeginInit();
            groupBox7.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox9.SuspendLayout();
            groupBox10.SuspendLayout();
            SuspendLayout();
            // 
            // pltMain
            // 
            pltMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pltMain.DisplayScale = 1.25F;
            pltMain.Location = new Point(437, 67);
            pltMain.Name = "pltMain";
            pltMain.Size = new Size(1043, 1193);
            pltMain.TabIndex = 0;
            // 
            // tmrPlot
            // 
            tmrPlot.Enabled = true;
            tmrPlot.Interval = 1;
            tmrPlot.Tick += tmrPlot_Tick;
            // 
            // lblIndenterForce
            // 
            lblIndenterForce.AutoSize = true;
            lblIndenterForce.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIndenterForce.Location = new Point(11, 9);
            lblIndenterForce.Name = "lblIndenterForce";
            lblIndenterForce.Size = new Size(398, 54);
            lblIndenterForce.TabIndex = 1;
            lblIndenterForce.Text = "Indenter Force: N/A";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox5);
            groupBox1.Location = new Point(11, 231);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(419, 227);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Indenter";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnIndenterConnect);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(cmbIndenterCOMPort);
            groupBox3.Location = new Point(6, 27);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(407, 95);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Connect";
            // 
            // btnIndenterConnect
            // 
            btnIndenterConnect.Location = new Point(6, 60);
            btnIndenterConnect.Name = "btnIndenterConnect";
            btnIndenterConnect.Size = new Size(395, 29);
            btnIndenterConnect.TabIndex = 2;
            btnIndenterConnect.Text = "Connect";
            btnIndenterConnect.UseVisualStyleBackColor = true;
            btnIndenterConnect.Click += btnIndenterConnect_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 29);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 1;
            label1.Text = "COM Port:";
            // 
            // cmbIndenterCOMPort
            // 
            cmbIndenterCOMPort.FormattingEnabled = true;
            cmbIndenterCOMPort.Location = new Point(87, 27);
            cmbIndenterCOMPort.Name = "cmbIndenterCOMPort";
            cmbIndenterCOMPort.Size = new Size(314, 28);
            cmbIndenterCOMPort.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label5);
            groupBox5.Controls.Add(numIndenterCalibration);
            groupBox5.Controls.Add(label4);
            groupBox5.Controls.Add(btnIndenterCalibrate);
            groupBox5.Location = new Point(6, 127);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(407, 93);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = "Calibration";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(370, 28);
            label5.Name = "label5";
            label5.Size = new Size(31, 20);
            label5.TabIndex = 3;
            label5.Text = "mg";
            // 
            // numIndenterCalibration
            // 
            numIndenterCalibration.Location = new Point(114, 27);
            numIndenterCalibration.Name = "numIndenterCalibration";
            numIndenterCalibration.Size = new Size(250, 27);
            numIndenterCalibration.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 28);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 1;
            label4.Text = "Probe Weight:";
            // 
            // btnIndenterCalibrate
            // 
            btnIndenterCalibrate.Location = new Point(6, 59);
            btnIndenterCalibrate.Name = "btnIndenterCalibrate";
            btnIndenterCalibrate.Size = new Size(395, 29);
            btnIndenterCalibrate.TabIndex = 0;
            btnIndenterCalibrate.Text = "Calibrate";
            btnIndenterCalibrate.UseVisualStyleBackColor = true;
            btnIndenterCalibrate.Click += btnIndenterCalibrate_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox6);
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Location = new Point(11, 464);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(419, 485);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Stage";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(btnHome);
            groupBox6.Controls.Add(btnStageCtrlHalt);
            groupBox6.Controls.Add(groupBox8);
            groupBox6.Controls.Add(groupBox7);
            groupBox6.Location = new Point(6, 121);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(407, 359);
            groupBox6.TabIndex = 6;
            groupBox6.TabStop = false;
            groupBox6.Text = "Controls";
            // 
            // btnHome
            // 
            btnHome.Location = new Point(242, 153);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(159, 68);
            btnHome.TabIndex = 3;
            btnHome.Text = "Move Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // btnStageCtrlHalt
            // 
            btnStageCtrlHalt.Location = new Point(242, 35);
            btnStageCtrlHalt.Name = "btnStageCtrlHalt";
            btnStageCtrlHalt.Size = new Size(159, 112);
            btnStageCtrlHalt.TabIndex = 2;
            btnStageCtrlHalt.Text = "HALT";
            btnStageCtrlHalt.UseVisualStyleBackColor = true;
            btnStageCtrlHalt.Click += btnStageCtrlHalt_Click;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(btnStageCtrlRelativeMove);
            groupBox8.Controls.Add(btnStageCtrlAbsoluteMove);
            groupBox8.Controls.Add(label11);
            groupBox8.Controls.Add(label10);
            groupBox8.Controls.Add(label9);
            groupBox8.Controls.Add(label8);
            groupBox8.Controls.Add(numStageCtrlAbsRelZum);
            groupBox8.Controls.Add(label7);
            groupBox8.Controls.Add(numStageCtrlAbsRelYum);
            groupBox8.Controls.Add(label6);
            groupBox8.Controls.Add(numStageCtrlAbsRelXum);
            groupBox8.Location = new Point(6, 227);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(395, 125);
            groupBox8.TabIndex = 1;
            groupBox8.TabStop = false;
            groupBox8.Text = "Absolute/Relative";
            // 
            // btnStageCtrlRelativeMove
            // 
            btnStageCtrlRelativeMove.Location = new Point(254, 75);
            btnStageCtrlRelativeMove.Name = "btnStageCtrlRelativeMove";
            btnStageCtrlRelativeMove.Size = new Size(135, 43);
            btnStageCtrlRelativeMove.TabIndex = 9;
            btnStageCtrlRelativeMove.Text = "Relative Move";
            btnStageCtrlRelativeMove.UseVisualStyleBackColor = true;
            btnStageCtrlRelativeMove.Click += btnStageCtrlRelativeMove_Click;
            // 
            // btnStageCtrlAbsoluteMove
            // 
            btnStageCtrlAbsoluteMove.Location = new Point(254, 27);
            btnStageCtrlAbsoluteMove.Name = "btnStageCtrlAbsoluteMove";
            btnStageCtrlAbsoluteMove.Size = new Size(135, 43);
            btnStageCtrlAbsoluteMove.TabIndex = 8;
            btnStageCtrlAbsoluteMove.Text = "Absolute Move";
            btnStageCtrlAbsoluteMove.UseVisualStyleBackColor = true;
            btnStageCtrlAbsoluteMove.Click += btnStageCtrlAbsoluteMove_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(218, 93);
            label11.Name = "label11";
            label11.Size = new Size(30, 20);
            label11.TabIndex = 7;
            label11.Text = "um";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(218, 61);
            label10.Name = "label10";
            label10.Size = new Size(30, 20);
            label10.TabIndex = 6;
            label10.Text = "um";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(218, 28);
            label9.Name = "label9";
            label9.Size = new Size(30, 20);
            label9.TabIndex = 0;
            label9.Text = "um";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 93);
            label8.Name = "label8";
            label8.Size = new Size(21, 20);
            label8.TabIndex = 5;
            label8.Text = "Z:";
            // 
            // numStageCtrlAbsRelZum
            // 
            numStageCtrlAbsRelZum.Location = new Point(33, 92);
            numStageCtrlAbsRelZum.Name = "numStageCtrlAbsRelZum";
            numStageCtrlAbsRelZum.Size = new Size(179, 27);
            numStageCtrlAbsRelZum.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 61);
            label7.Name = "label7";
            label7.Size = new Size(20, 20);
            label7.TabIndex = 3;
            label7.Text = "Y:";
            // 
            // numStageCtrlAbsRelYum
            // 
            numStageCtrlAbsRelYum.Location = new Point(33, 59);
            numStageCtrlAbsRelYum.Name = "numStageCtrlAbsRelYum";
            numStageCtrlAbsRelYum.Size = new Size(179, 27);
            numStageCtrlAbsRelYum.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 28);
            label6.Name = "label6";
            label6.Size = new Size(21, 20);
            label6.TabIndex = 1;
            label6.Text = "X:";
            // 
            // numStageCtrlAbsRelXum
            // 
            numStageCtrlAbsRelXum.Location = new Point(33, 27);
            numStageCtrlAbsRelXum.Name = "numStageCtrlAbsRelXum";
            numStageCtrlAbsRelXum.Size = new Size(179, 27);
            numStageCtrlAbsRelXum.TabIndex = 0;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(btnStageCtrlRunXRightYUp);
            groupBox7.Controls.Add(btnStageCtrlRunXRightYDown);
            groupBox7.Controls.Add(btnStageCtrlRunXLeftYDown);
            groupBox7.Controls.Add(btnStageCtrlRunXLeftYUp);
            groupBox7.Controls.Add(btnStageCtrlRunZDown);
            groupBox7.Controls.Add(btnStageCtrlRunZUp);
            groupBox7.Controls.Add(btnStageCtrlRunYDown);
            groupBox7.Controls.Add(btnStageCtrlRunXRight);
            groupBox7.Controls.Add(btnStageCtrlRunXLeft);
            groupBox7.Controls.Add(btnStageCtrlRunYUp);
            groupBox7.Location = new Point(6, 27);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(230, 195);
            groupBox7.TabIndex = 0;
            groupBox7.TabStop = false;
            groupBox7.Text = "Run";
            // 
            // btnStageCtrlRunXRightYUp
            // 
            btnStageCtrlRunXRightYUp.Location = new Point(118, 27);
            btnStageCtrlRunXRightYUp.Name = "btnStageCtrlRunXRightYUp";
            btnStageCtrlRunXRightYUp.Size = new Size(50, 51);
            btnStageCtrlRunXRightYUp.TabIndex = 11;
            btnStageCtrlRunXRightYUp.Text = "↗";
            btnStageCtrlRunXRightYUp.UseVisualStyleBackColor = true;
            btnStageCtrlRunXRightYUp.MouseDown += btnStageCtrlRunXRightYUp_MouseDown;
            btnStageCtrlRunXRightYUp.MouseUp += btnStageCtrlRunXRightYUp_MouseUp;
            // 
            // btnStageCtrlRunXRightYDown
            // 
            btnStageCtrlRunXRightYDown.Location = new Point(118, 139);
            btnStageCtrlRunXRightYDown.Name = "btnStageCtrlRunXRightYDown";
            btnStageCtrlRunXRightYDown.Size = new Size(50, 51);
            btnStageCtrlRunXRightYDown.TabIndex = 10;
            btnStageCtrlRunXRightYDown.Text = "↘";
            btnStageCtrlRunXRightYDown.UseVisualStyleBackColor = true;
            btnStageCtrlRunXRightYDown.MouseDown += btnStageCtrlRunXRightYDown_MouseDown;
            btnStageCtrlRunXRightYDown.MouseUp += btnStageCtrlRunXRightYDown_MouseUp;
            // 
            // btnStageCtrlRunXLeftYDown
            // 
            btnStageCtrlRunXLeftYDown.Location = new Point(6, 139);
            btnStageCtrlRunXLeftYDown.Name = "btnStageCtrlRunXLeftYDown";
            btnStageCtrlRunXLeftYDown.Size = new Size(50, 51);
            btnStageCtrlRunXLeftYDown.TabIndex = 9;
            btnStageCtrlRunXLeftYDown.Text = "↙";
            btnStageCtrlRunXLeftYDown.UseVisualStyleBackColor = true;
            btnStageCtrlRunXLeftYDown.MouseDown += btnStageCtrlRunXLeftYDown_MouseDown;
            btnStageCtrlRunXLeftYDown.MouseUp += btnStageCtrlRunXLeftYDown_MouseUp;
            // 
            // btnStageCtrlRunXLeftYUp
            // 
            btnStageCtrlRunXLeftYUp.Location = new Point(6, 27);
            btnStageCtrlRunXLeftYUp.Name = "btnStageCtrlRunXLeftYUp";
            btnStageCtrlRunXLeftYUp.Size = new Size(50, 51);
            btnStageCtrlRunXLeftYUp.TabIndex = 8;
            btnStageCtrlRunXLeftYUp.Text = "↖";
            btnStageCtrlRunXLeftYUp.UseVisualStyleBackColor = true;
            btnStageCtrlRunXLeftYUp.MouseDown += btnStageCtrlRunXLeftYUp_MouseDown;
            btnStageCtrlRunXLeftYUp.MouseUp += btnStageCtrlRunXLeftYUp_MouseUp;
            // 
            // btnStageCtrlRunZDown
            // 
            btnStageCtrlRunZDown.Location = new Point(174, 139);
            btnStageCtrlRunZDown.Name = "btnStageCtrlRunZDown";
            btnStageCtrlRunZDown.Size = new Size(50, 51);
            btnStageCtrlRunZDown.TabIndex = 7;
            btnStageCtrlRunZDown.Text = "↓";
            btnStageCtrlRunZDown.UseVisualStyleBackColor = true;
            btnStageCtrlRunZDown.MouseDown += btnStageCtrlRunZDown_MouseDown;
            btnStageCtrlRunZDown.MouseUp += btnStageCtrlRunZDown_MouseUp;
            // 
            // btnStageCtrlRunZUp
            // 
            btnStageCtrlRunZUp.Location = new Point(174, 27);
            btnStageCtrlRunZUp.Name = "btnStageCtrlRunZUp";
            btnStageCtrlRunZUp.Size = new Size(50, 51);
            btnStageCtrlRunZUp.TabIndex = 6;
            btnStageCtrlRunZUp.Text = "↑";
            btnStageCtrlRunZUp.UseVisualStyleBackColor = true;
            btnStageCtrlRunZUp.MouseDown += btnStageCtrlRunZUp_MouseDown;
            btnStageCtrlRunZUp.MouseUp += btnStageCtrlRunZUp_MouseUp;
            // 
            // btnStageCtrlRunYDown
            // 
            btnStageCtrlRunYDown.Location = new Point(62, 139);
            btnStageCtrlRunYDown.Name = "btnStageCtrlRunYDown";
            btnStageCtrlRunYDown.Size = new Size(50, 51);
            btnStageCtrlRunYDown.TabIndex = 4;
            btnStageCtrlRunYDown.Text = "↓";
            btnStageCtrlRunYDown.UseVisualStyleBackColor = true;
            btnStageCtrlRunYDown.MouseDown += btnStageCtrlRunYDown_MouseDown;
            btnStageCtrlRunYDown.MouseUp += btnStageCtrlRunYDown_MouseUp;
            // 
            // btnStageCtrlRunXRight
            // 
            btnStageCtrlRunXRight.Location = new Point(118, 83);
            btnStageCtrlRunXRight.Name = "btnStageCtrlRunXRight";
            btnStageCtrlRunXRight.Size = new Size(50, 51);
            btnStageCtrlRunXRight.TabIndex = 3;
            btnStageCtrlRunXRight.Text = "→";
            btnStageCtrlRunXRight.UseVisualStyleBackColor = true;
            btnStageCtrlRunXRight.MouseDown += btnStageCtrlRunXRight_MouseDown;
            btnStageCtrlRunXRight.MouseUp += btnStageCtrlRunXRight_MouseUp;
            // 
            // btnStageCtrlRunXLeft
            // 
            btnStageCtrlRunXLeft.Location = new Point(6, 83);
            btnStageCtrlRunXLeft.Name = "btnStageCtrlRunXLeft";
            btnStageCtrlRunXLeft.Size = new Size(50, 51);
            btnStageCtrlRunXLeft.TabIndex = 2;
            btnStageCtrlRunXLeft.Text = "←";
            btnStageCtrlRunXLeft.UseVisualStyleBackColor = true;
            btnStageCtrlRunXLeft.MouseDown += btnStageCtrlRunXLeft_MouseDown;
            btnStageCtrlRunXLeft.MouseUp += btnStageCtrlRunXLeft_MouseUp;
            // 
            // btnStageCtrlRunYUp
            // 
            btnStageCtrlRunYUp.Location = new Point(62, 27);
            btnStageCtrlRunYUp.Name = "btnStageCtrlRunYUp";
            btnStageCtrlRunYUp.Size = new Size(50, 51);
            btnStageCtrlRunYUp.TabIndex = 0;
            btnStageCtrlRunYUp.Text = "↑";
            btnStageCtrlRunYUp.UseVisualStyleBackColor = true;
            btnStageCtrlRunYUp.MouseDown += btnStageCtrlRunYUp_MouseDown;
            btnStageCtrlRunYUp.MouseUp += btnStageCtrlRunYUp_MouseUp;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnStageConnect);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(cmbStageCOMPort);
            groupBox4.Location = new Point(6, 27);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(407, 95);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Connect";
            // 
            // btnStageConnect
            // 
            btnStageConnect.Location = new Point(6, 60);
            btnStageConnect.Name = "btnStageConnect";
            btnStageConnect.Size = new Size(395, 29);
            btnStageConnect.TabIndex = 4;
            btnStageConnect.Text = "Connect";
            btnStageConnect.UseVisualStyleBackColor = true;
            btnStageConnect.Click += btnStageConnect_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 29);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 2;
            label2.Text = "COM Port:";
            // 
            // cmbStageCOMPort
            // 
            cmbStageCOMPort.FormattingEnabled = true;
            cmbStageCOMPort.Location = new Point(87, 27);
            cmbStageCOMPort.Name = "cmbStageCOMPort";
            cmbStageCOMPort.Size = new Size(314, 28);
            cmbStageCOMPort.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(987, 9);
            label3.Name = "label3";
            label3.Size = new Size(493, 20);
            label3.TabIndex = 4;
            label3.Text = "Use this as intended. There are barely any error checks. Things WILL crash!";
            // 
            // lblStageX
            // 
            lblStageX.AutoSize = true;
            lblStageX.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStageX.Location = new Point(11, 67);
            lblStageX.Name = "lblStageX";
            lblStageX.Size = new Size(266, 54);
            lblStageX.TabIndex = 5;
            lblStageX.Text = "Stage X: N/A";
            // 
            // lblStageY
            // 
            lblStageY.AutoSize = true;
            lblStageY.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStageY.Location = new Point(11, 120);
            lblStageY.Name = "lblStageY";
            lblStageY.Size = new Size(264, 54);
            lblStageY.TabIndex = 6;
            lblStageY.Text = "Stage Y: N/A";
            // 
            // lblStageZ
            // 
            lblStageZ.AutoSize = true;
            lblStageZ.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStageZ.Location = new Point(11, 173);
            lblStageZ.Name = "lblStageZ";
            lblStageZ.Size = new Size(264, 54);
            lblStageZ.TabIndex = 7;
            lblStageZ.Text = "Stage Z: N/A";
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(groupBox10);
            groupBox9.Controls.Add(btnDataToggleCollection);
            groupBox9.Controls.Add(btnDataSelectDirectory);
            groupBox9.Controls.Add(txtDataFileName);
            groupBox9.Controls.Add(txtDataDirectory);
            groupBox9.Controls.Add(label13);
            groupBox9.Controls.Add(label12);
            groupBox9.Location = new Point(11, 956);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(419, 304);
            groupBox9.TabIndex = 8;
            groupBox9.TabStop = false;
            groupBox9.Text = "Data Collection";
            // 
            // groupBox10
            // 
            groupBox10.Controls.Add(btnDataSetSampleData);
            groupBox10.Controls.Add(label14);
            groupBox10.Controls.Add(txtDataSampleData);
            groupBox10.Location = new Point(7, 139);
            groupBox10.Margin = new Padding(3, 4, 3, 4);
            groupBox10.Name = "groupBox10";
            groupBox10.Padding = new Padding(3, 4, 3, 4);
            groupBox10.Size = new Size(406, 159);
            groupBox10.TabIndex = 6;
            groupBox10.TabStop = false;
            groupBox10.Text = "Sample Data";
            // 
            // btnDataSetSampleData
            // 
            btnDataSetSampleData.Location = new Point(7, 68);
            btnDataSetSampleData.Margin = new Padding(3, 4, 3, 4);
            btnDataSetSampleData.Name = "btnDataSetSampleData";
            btnDataSetSampleData.Size = new Size(393, 83);
            btnDataSetSampleData.TabIndex = 3;
            btnDataSetSampleData.Text = "Set Sample Data";
            btnDataSetSampleData.UseVisualStyleBackColor = true;
            btnDataSetSampleData.Click += btnDataSetSampleData_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(7, 33);
            label14.Name = "label14";
            label14.Size = new Size(98, 20);
            label14.TabIndex = 2;
            label14.Text = "Sample Data:";
            // 
            // txtDataSampleData
            // 
            txtDataSampleData.Location = new Point(101, 29);
            txtDataSampleData.Margin = new Padding(3, 4, 3, 4);
            txtDataSampleData.Name = "txtDataSampleData";
            txtDataSampleData.Size = new Size(298, 27);
            txtDataSampleData.TabIndex = 0;
            // 
            // btnDataToggleCollection
            // 
            btnDataToggleCollection.Location = new Point(6, 92);
            btnDataToggleCollection.Name = "btnDataToggleCollection";
            btnDataToggleCollection.Size = new Size(407, 40);
            btnDataToggleCollection.TabIndex = 5;
            btnDataToggleCollection.Text = "Start Data Collection";
            btnDataToggleCollection.UseVisualStyleBackColor = true;
            btnDataToggleCollection.Click += btnDataToggleCollection_Click;
            // 
            // btnDataSelectDirectory
            // 
            btnDataSelectDirectory.Location = new Point(370, 27);
            btnDataSelectDirectory.Name = "btnDataSelectDirectory";
            btnDataSelectDirectory.Size = new Size(43, 29);
            btnDataSelectDirectory.TabIndex = 4;
            btnDataSelectDirectory.Text = "...";
            btnDataSelectDirectory.UseVisualStyleBackColor = true;
            btnDataSelectDirectory.Click += btnDataSelectDirectory_Click;
            // 
            // txtDataFileName
            // 
            txtDataFileName.Location = new Point(85, 59);
            txtDataFileName.Name = "txtDataFileName";
            txtDataFileName.Size = new Size(279, 27);
            txtDataFileName.TabIndex = 3;
            // 
            // txtDataDirectory
            // 
            txtDataDirectory.Location = new Point(85, 27);
            txtDataDirectory.Name = "txtDataDirectory";
            txtDataDirectory.Size = new Size(279, 27);
            txtDataDirectory.TabIndex = 2;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 61);
            label13.Name = "label13";
            label13.Size = new Size(79, 20);
            label13.TabIndex = 1;
            label13.Text = "File Name:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 29);
            label12.Name = "label12";
            label12.Size = new Size(73, 20);
            label12.TabIndex = 0;
            label12.Text = "Directory:";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1493, 1272);
            Controls.Add(groupBox9);
            Controls.Add(lblStageZ);
            Controls.Add(lblStageY);
            Controls.Add(lblStageX);
            Controls.Add(label3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblIndenterForce);
            Controls.Add(pltMain);
            Name = "frmMain";
            Text = "Microscope Cell Poker";
            Load += frmMain_Load;
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numIndenterCalibration).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numStageCtrlAbsRelZum).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStageCtrlAbsRelYum).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStageCtrlAbsRelXum).EndInit();
            groupBox7.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            groupBox10.ResumeLayout(false);
            groupBox10.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ScottPlot.WinForms.FormsPlot pltMain;
        private System.Windows.Forms.Timer tmrPlot;
        private Label lblIndenterForce;
        private GroupBox groupBox1;
        private Button btnIndenterConnect;
        private Label label1;
        private ComboBox cmbIndenterCOMPort;
        private GroupBox groupBox2;
        private Button btnStageConnect;
        private ComboBox cmbStageCOMPort;
        private Label label2;
        private Label label3;
        private GroupBox groupBox4;
        private Button btnIndenterCalibrate;
        private GroupBox groupBox3;
        private GroupBox groupBox5;
        private Label label5;
        private NumericUpDown numIndenterCalibration;
        private Label label4;
        private GroupBox groupBox6;
        private Label lblStageX;
        private Label lblStageY;
        private Label lblStageZ;
        private GroupBox groupBox7;
        private Button btnStageCtrlRunYDown;
        private Button btnStageCtrlRunXRight;
        private Button btnStageCtrlRunXLeft;
        private Button btnStageCtrlRunYUp;
        private Button btnStageCtrlRunZDown;
        private Button btnStageCtrlRunZUp;
        private GroupBox groupBox8;
        private Label label6;
        private NumericUpDown numStageCtrlAbsRelXum;
        private Button btnStageCtrlRunXRightYUp;
        private Button btnStageCtrlRunXRightYDown;
        private Button btnStageCtrlRunXLeftYDown;
        private Button btnStageCtrlRunXLeftYUp;
        private Button btnStageCtrlHalt;
        private Button btnHome;
        private Button btnStageCtrlRelativeMove;
        private Button btnStageCtrlAbsoluteMove;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private NumericUpDown numStageCtrlAbsRelZum;
        private Label label7;
        private NumericUpDown numStageCtrlAbsRelYum;
        private GroupBox groupBox9;
        private Button btnDataToggleCollection;
        private Button btnDataSelectDirectory;
        private TextBox txtDataFileName;
        private TextBox txtDataDirectory;
        private Label label13;
        private Label label12;
        private GroupBox groupBox10;
        private Button btnDataSetSampleData;
        private Label label14;
        private TextBox txtDataSampleData;
    }
}
