namespace Automatic_Cradle_Control
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serial = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tittleLabel = new System.Windows.Forms.Label();
            this.baudCombo = new System.Windows.Forms.ComboBox();
            this.portGroup = new System.Windows.Forms.GroupBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.baudRatelabel = new System.Windows.Forms.Label();
            this.portLabel = new System.Windows.Forms.Label();
            this.COMcombo = new System.Windows.Forms.ComboBox();
            this.settingsGroup = new System.Windows.Forms.GroupBox();
            this.speedLabel = new System.Windows.Forms.Label();
            this.slpTimeButton = new System.Windows.Forms.Button();
            this.slpTimeText = new System.Windows.Forms.TextBox();
            this.setTimeButton = new System.Windows.Forms.Button();
            this.setAngleButton = new System.Windows.Forms.Button();
            this.setSpdButton = new System.Windows.Forms.Button();
            this.speedCombo = new System.Windows.Forms.ComboBox();
            this.angleCombo = new System.Windows.Forms.ComboBox();
            this.timeText = new System.Windows.Forms.TextBox();
            this.teminalGroup = new System.Windows.Forms.GroupBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.Terminal = new System.Windows.Forms.ListBox();
            this.termTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.timPauseButton = new System.Windows.Forms.Button();
            this.offTimButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.facRstButton = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.speedValueLabel = new System.Windows.Forms.Label();
            this.RangeLabel = new System.Windows.Forms.Label();
            this.StopFlagLabel = new System.Windows.Forms.Label();
            this.ValuesGroupBox = new System.Windows.Forms.GroupBox();
            this.rangeValueLabel = new System.Windows.Forms.Label();
            this.stopFlagStateLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.portGroup.SuspendLayout();
            this.settingsGroup.SuspendLayout();
            this.teminalGroup.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.ValuesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // serial
            // 
            this.serial.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serial_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tittleLabel);
            this.groupBox1.Location = new System.Drawing.Point(2, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(780, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // tittleLabel
            // 
            this.tittleLabel.AutoSize = true;
            this.tittleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tittleLabel.Location = new System.Drawing.Point(9, 16);
            this.tittleLabel.Name = "tittleLabel";
            this.tittleLabel.Size = new System.Drawing.Size(540, 73);
            this.tittleLabel.TabIndex = 0;
            this.tittleLabel.Text = "Automatic Cradle";
            this.tittleLabel.DoubleClick += new System.EventHandler(this.tittleLabel_DoubleClick);
            // 
            // baudCombo
            // 
            this.baudCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.baudCombo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.baudCombo.ForeColor = System.Drawing.Color.Yellow;
            this.baudCombo.FormattingEnabled = true;
            this.baudCombo.Location = new System.Drawing.Point(97, 80);
            this.baudCombo.Name = "baudCombo";
            this.baudCombo.Size = new System.Drawing.Size(121, 24);
            this.baudCombo.TabIndex = 1;
            // 
            // portGroup
            // 
            this.portGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.portGroup.Controls.Add(this.connectButton);
            this.portGroup.Controls.Add(this.baudRatelabel);
            this.portGroup.Controls.Add(this.portLabel);
            this.portGroup.Controls.Add(this.COMcombo);
            this.portGroup.Controls.Add(this.baudCombo);
            this.portGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.portGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.portGroup.Location = new System.Drawing.Point(15, 112);
            this.portGroup.Name = "portGroup";
            this.portGroup.Size = new System.Drawing.Size(240, 175);
            this.portGroup.TabIndex = 3;
            this.portGroup.TabStop = false;
            this.portGroup.Text = "Connection ";
            // 
            // connectButton
            // 
            this.connectButton.BackColor = System.Drawing.Color.Gray;
            this.connectButton.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.connectButton.ForeColor = System.Drawing.Color.Yellow;
            this.connectButton.Location = new System.Drawing.Point(44, 130);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(174, 30);
            this.connectButton.TabIndex = 4;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = false;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // baudRatelabel
            // 
            this.baudRatelabel.AutoSize = true;
            this.baudRatelabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.baudRatelabel.ForeColor = System.Drawing.Color.Yellow;
            this.baudRatelabel.Location = new System.Drawing.Point(41, 81);
            this.baudRatelabel.Name = "baudRatelabel";
            this.baudRatelabel.Size = new System.Drawing.Size(41, 16);
            this.baudRatelabel.TabIndex = 3;
            this.baudRatelabel.Text = "Baud";
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.portLabel.ForeColor = System.Drawing.Color.Yellow;
            this.portLabel.Location = new System.Drawing.Point(24, 40);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(67, 16);
            this.portLabel.TabIndex = 2;
            this.portLabel.Text = "COM port";
            // 
            // COMcombo
            // 
            this.COMcombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.COMcombo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.COMcombo.ForeColor = System.Drawing.Color.Yellow;
            this.COMcombo.FormattingEnabled = true;
            this.COMcombo.Location = new System.Drawing.Point(97, 40);
            this.COMcombo.Name = "COMcombo";
            this.COMcombo.Size = new System.Drawing.Size(121, 24);
            this.COMcombo.TabIndex = 0;
            // 
            // settingsGroup
            // 
            this.settingsGroup.Controls.Add(this.ValuesGroupBox);
            this.settingsGroup.Controls.Add(this.slpTimeButton);
            this.settingsGroup.Controls.Add(this.slpTimeText);
            this.settingsGroup.Controls.Add(this.setTimeButton);
            this.settingsGroup.Controls.Add(this.setAngleButton);
            this.settingsGroup.Controls.Add(this.setSpdButton);
            this.settingsGroup.Controls.Add(this.speedCombo);
            this.settingsGroup.Controls.Add(this.angleCombo);
            this.settingsGroup.Controls.Add(this.timeText);
            this.settingsGroup.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.settingsGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.settingsGroup.Location = new System.Drawing.Point(275, 112);
            this.settingsGroup.Name = "settingsGroup";
            this.settingsGroup.Size = new System.Drawing.Size(240, 332);
            this.settingsGroup.TabIndex = 5;
            this.settingsGroup.TabStop = false;
            this.settingsGroup.Text = "Parameters";
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.speedLabel.Location = new System.Drawing.Point(6, 12);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(45, 14);
            this.speedLabel.TabIndex = 16;
            this.speedLabel.Text = "Speed:";
            // 
            // slpTimeButton
            // 
            this.slpTimeButton.BackColor = System.Drawing.Color.Gray;
            this.slpTimeButton.ForeColor = System.Drawing.Color.Yellow;
            this.slpTimeButton.Location = new System.Drawing.Point(160, 161);
            this.slpTimeButton.Name = "slpTimeButton";
            this.slpTimeButton.Size = new System.Drawing.Size(74, 23);
            this.slpTimeButton.TabIndex = 15;
            this.slpTimeButton.Text = "Set Sleep";
            this.slpTimeButton.UseVisualStyleBackColor = false;
            this.slpTimeButton.Click += new System.EventHandler(this.slpTimeButton_Click);
            // 
            // slpTimeText
            // 
            this.slpTimeText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.slpTimeText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.slpTimeText.ForeColor = System.Drawing.Color.Yellow;
            this.slpTimeText.Location = new System.Drawing.Point(15, 160);
            this.slpTimeText.Name = "slpTimeText";
            this.slpTimeText.Size = new System.Drawing.Size(130, 22);
            this.slpTimeText.TabIndex = 14;
            // 
            // setTimeButton
            // 
            this.setTimeButton.BackColor = System.Drawing.Color.Gray;
            this.setTimeButton.ForeColor = System.Drawing.Color.Yellow;
            this.setTimeButton.Location = new System.Drawing.Point(160, 121);
            this.setTimeButton.Name = "setTimeButton";
            this.setTimeButton.Size = new System.Drawing.Size(74, 23);
            this.setTimeButton.TabIndex = 13;
            this.setTimeButton.Text = "Set Time";
            this.setTimeButton.UseVisualStyleBackColor = false;
            this.setTimeButton.Click += new System.EventHandler(this.setTimeButton_Click);
            // 
            // setAngleButton
            // 
            this.setAngleButton.BackColor = System.Drawing.Color.Gray;
            this.setAngleButton.ForeColor = System.Drawing.Color.Yellow;
            this.setAngleButton.Location = new System.Drawing.Point(160, 81);
            this.setAngleButton.Name = "setAngleButton";
            this.setAngleButton.Size = new System.Drawing.Size(74, 23);
            this.setAngleButton.TabIndex = 12;
            this.setAngleButton.Text = "Set Angle";
            this.setAngleButton.UseVisualStyleBackColor = false;
            this.setAngleButton.Click += new System.EventHandler(this.setAngleButton_Click);
            // 
            // setSpdButton
            // 
            this.setSpdButton.BackColor = System.Drawing.Color.Gray;
            this.setSpdButton.ForeColor = System.Drawing.Color.Yellow;
            this.setSpdButton.Location = new System.Drawing.Point(160, 41);
            this.setSpdButton.Name = "setSpdButton";
            this.setSpdButton.Size = new System.Drawing.Size(74, 23);
            this.setSpdButton.TabIndex = 11;
            this.setSpdButton.Text = "Set  Speed";
            this.setSpdButton.UseVisualStyleBackColor = false;
            this.setSpdButton.Click += new System.EventHandler(this.setSpdButton_Click);
            // 
            // speedCombo
            // 
            this.speedCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.speedCombo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.speedCombo.ForeColor = System.Drawing.Color.Yellow;
            this.speedCombo.FormattingEnabled = true;
            this.speedCombo.Location = new System.Drawing.Point(15, 39);
            this.speedCombo.Name = "speedCombo";
            this.speedCombo.Size = new System.Drawing.Size(130, 24);
            this.speedCombo.TabIndex = 10;
            // 
            // angleCombo
            // 
            this.angleCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.angleCombo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.angleCombo.ForeColor = System.Drawing.Color.Yellow;
            this.angleCombo.FormattingEnabled = true;
            this.angleCombo.Location = new System.Drawing.Point(15, 80);
            this.angleCombo.Name = "angleCombo";
            this.angleCombo.Size = new System.Drawing.Size(130, 24);
            this.angleCombo.TabIndex = 9;
            // 
            // timeText
            // 
            this.timeText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.timeText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeText.ForeColor = System.Drawing.Color.Yellow;
            this.timeText.Location = new System.Drawing.Point(15, 120);
            this.timeText.Name = "timeText";
            this.timeText.Size = new System.Drawing.Size(130, 22);
            this.timeText.TabIndex = 5;
            // 
            // teminalGroup
            // 
            this.teminalGroup.Controls.Add(this.clearButton);
            this.teminalGroup.Controls.Add(this.Terminal);
            this.teminalGroup.Controls.Add(this.termTextBox);
            this.teminalGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.teminalGroup.Location = new System.Drawing.Point(530, 112);
            this.teminalGroup.Name = "teminalGroup";
            this.teminalGroup.Size = new System.Drawing.Size(240, 332);
            this.teminalGroup.TabIndex = 6;
            this.teminalGroup.TabStop = false;
            this.teminalGroup.Text = "Terminal";
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Gray;
            this.clearButton.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clearButton.ForeColor = System.Drawing.Color.Yellow;
            this.clearButton.Location = new System.Drawing.Point(125, 304);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 23);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Terminal
            // 
            this.Terminal.BackColor = System.Drawing.SystemColors.MenuText;
            this.Terminal.ForeColor = System.Drawing.Color.Lime;
            this.Terminal.FormattingEnabled = true;
            this.Terminal.Location = new System.Drawing.Point(15, 17);
            this.Terminal.Name = "Terminal";
            this.Terminal.Size = new System.Drawing.Size(210, 277);
            this.Terminal.TabIndex = 1;
            // 
            // termTextBox
            // 
            this.termTextBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.termTextBox.ForeColor = System.Drawing.Color.Lime;
            this.termTextBox.Location = new System.Drawing.Point(15, 306);
            this.termTextBox.Name = "termTextBox";
            this.termTextBox.Size = new System.Drawing.Size(100, 20);
            this.termTextBox.TabIndex = 0;
            this.termTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.termTextBox_KeyUp);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.timPauseButton);
            this.groupBox2.Controls.Add(this.offTimButton);
            this.groupBox2.Controls.Add(this.stopButton);
            this.groupBox2.Controls.Add(this.facRstButton);
            this.groupBox2.Controls.Add(this.Reset);
            this.groupBox2.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(15, 293);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 151);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // timPauseButton
            // 
            this.timPauseButton.AccessibleRole = System.Windows.Forms.AccessibleRole.WhiteSpace;
            this.timPauseButton.BackColor = System.Drawing.Color.Gray;
            this.timPauseButton.ForeColor = System.Drawing.Color.Yellow;
            this.timPauseButton.Location = new System.Drawing.Point(10, 102);
            this.timPauseButton.Name = "timPauseButton";
            this.timPauseButton.Size = new System.Drawing.Size(100, 23);
            this.timPauseButton.TabIndex = 4;
            this.timPauseButton.Text = "Timer Pause";
            this.timPauseButton.UseVisualStyleBackColor = false;
            this.timPauseButton.Click += new System.EventHandler(this.timPauseButton_Click);
            // 
            // offTimButton
            // 
            this.offTimButton.AccessibleRole = System.Windows.Forms.AccessibleRole.WhiteSpace;
            this.offTimButton.BackColor = System.Drawing.Color.Gray;
            this.offTimButton.ForeColor = System.Drawing.Color.Yellow;
            this.offTimButton.Location = new System.Drawing.Point(10, 62);
            this.offTimButton.Name = "offTimButton";
            this.offTimButton.Size = new System.Drawing.Size(100, 23);
            this.offTimButton.TabIndex = 3;
            this.offTimButton.Text = "Timer OFF";
            this.offTimButton.UseVisualStyleBackColor = false;
            this.offTimButton.Click += new System.EventHandler(this.offTimButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.Gray;
            this.stopButton.ForeColor = System.Drawing.Color.Yellow;
            this.stopButton.Location = new System.Drawing.Point(10, 22);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(100, 23);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // facRstButton
            // 
            this.facRstButton.BackColor = System.Drawing.Color.Gray;
            this.facRstButton.ForeColor = System.Drawing.Color.Yellow;
            this.facRstButton.Location = new System.Drawing.Point(130, 62);
            this.facRstButton.Name = "facRstButton";
            this.facRstButton.Size = new System.Drawing.Size(100, 23);
            this.facRstButton.TabIndex = 1;
            this.facRstButton.Text = "Factory Rst";
            this.facRstButton.UseVisualStyleBackColor = false;
            this.facRstButton.Click += new System.EventHandler(this.facRstButton_Click);
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.Gray;
            this.Reset.ForeColor = System.Drawing.Color.Yellow;
            this.Reset.Location = new System.Drawing.Point(130, 22);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(100, 23);
            this.Reset.TabIndex = 0;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // speedValueLabel
            // 
            this.speedValueLabel.AutoSize = true;
            this.speedValueLabel.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.speedValueLabel.ForeColor = System.Drawing.Color.Lime;
            this.speedValueLabel.Location = new System.Drawing.Point(65, 10);
            this.speedValueLabel.Name = "speedValueLabel";
            this.speedValueLabel.Size = new System.Drawing.Size(0, 16);
            this.speedValueLabel.TabIndex = 17;
            // 
            // RangeLabel
            // 
            this.RangeLabel.AutoSize = true;
            this.RangeLabel.Location = new System.Drawing.Point(6, 40);
            this.RangeLabel.Name = "RangeLabel";
            this.RangeLabel.Size = new System.Drawing.Size(44, 14);
            this.RangeLabel.TabIndex = 18;
            this.RangeLabel.Text = "Range:";
            // 
            // StopFlagLabel
            // 
            this.StopFlagLabel.AutoSize = true;
            this.StopFlagLabel.Location = new System.Drawing.Point(6, 68);
            this.StopFlagLabel.Name = "StopFlagLabel";
            this.StopFlagLabel.Size = new System.Drawing.Size(57, 14);
            this.StopFlagLabel.TabIndex = 19;
            this.StopFlagLabel.Text = "StopFlag:";
            // 
            // ValuesGroupBox
            // 
            this.ValuesGroupBox.Controls.Add(this.stopFlagStateLabel);
            this.ValuesGroupBox.Controls.Add(this.StopFlagLabel);
            this.ValuesGroupBox.Controls.Add(this.rangeValueLabel);
            this.ValuesGroupBox.Controls.Add(this.RangeLabel);
            this.ValuesGroupBox.Controls.Add(this.speedValueLabel);
            this.ValuesGroupBox.Controls.Add(this.speedLabel);
            this.ValuesGroupBox.Location = new System.Drawing.Point(15, 230);
            this.ValuesGroupBox.Name = "ValuesGroupBox";
            this.ValuesGroupBox.Size = new System.Drawing.Size(105, 90);
            this.ValuesGroupBox.TabIndex = 20;
            this.ValuesGroupBox.TabStop = false;
            // 
            // rangeValueLabel
            // 
            this.rangeValueLabel.AutoSize = true;
            this.rangeValueLabel.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.rangeValueLabel.ForeColor = System.Drawing.Color.Lime;
            this.rangeValueLabel.Location = new System.Drawing.Point(65, 38);
            this.rangeValueLabel.Name = "rangeValueLabel";
            this.rangeValueLabel.Size = new System.Drawing.Size(0, 16);
            this.rangeValueLabel.TabIndex = 19;
            // 
            // stopFlagStateLabel
            // 
            this.stopFlagStateLabel.AutoSize = true;
            this.stopFlagStateLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.stopFlagStateLabel.ForeColor = System.Drawing.Color.Lime;
            this.stopFlagStateLabel.Location = new System.Drawing.Point(65, 68);
            this.stopFlagStateLabel.Name = "stopFlagStateLabel";
            this.stopFlagStateLabel.Size = new System.Drawing.Size(0, 14);
            this.stopFlagStateLabel.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(784, 456);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.teminalGroup);
            this.Controls.Add(this.settingsGroup);
            this.Controls.Add(this.portGroup);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.portGroup.ResumeLayout(false);
            this.portGroup.PerformLayout();
            this.settingsGroup.ResumeLayout(false);
            this.settingsGroup.PerformLayout();
            this.teminalGroup.ResumeLayout(false);
            this.teminalGroup.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ValuesGroupBox.ResumeLayout(false);
            this.ValuesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serial;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label tittleLabel;
        private System.Windows.Forms.ComboBox baudCombo;
        private System.Windows.Forms.GroupBox portGroup;
        private System.Windows.Forms.Label baudRatelabel;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.ComboBox COMcombo;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.GroupBox settingsGroup;
        private System.Windows.Forms.GroupBox teminalGroup;
        private System.Windows.Forms.TextBox termTextBox;
        private System.Windows.Forms.ListBox Terminal;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button offTimButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button facRstButton;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.ComboBox speedCombo;
        private System.Windows.Forms.ComboBox angleCombo;
        private System.Windows.Forms.TextBox timeText;
        private System.Windows.Forms.Button setTimeButton;
        private System.Windows.Forms.Button setAngleButton;
        private System.Windows.Forms.Button setSpdButton;
        private System.Windows.Forms.Button timPauseButton;
        private System.Windows.Forms.Button slpTimeButton;
        private System.Windows.Forms.TextBox slpTimeText;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Label StopFlagLabel;
        private System.Windows.Forms.Label RangeLabel;
        public System.Windows.Forms.GroupBox ValuesGroupBox;
        public System.Windows.Forms.Label stopFlagStateLabel;
        public System.Windows.Forms.Label speedValueLabel;
        public System.Windows.Forms.Label rangeValueLabel;
    }
}

