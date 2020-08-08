namespace SimpleStreamTimer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.chkShowTray = new System.Windows.Forms.CheckBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.numHours = new System.Windows.Forms.NumericUpDown();
            this.lblTime = new System.Windows.Forms.Label();
            this.chkShowHours = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numMinutes = new System.Windows.Forms.NumericUpDown();
            this.numSeconds = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblAlarm = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.grpOptions.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSeconds)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Simple Timer";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.BalloonTipClicked += new System.EventHandler(this.notifyIcon1_DoubleClick);
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // grpOptions
            // 
            this.grpOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOptions.Controls.Add(this.label1);
            this.grpOptions.Controls.Add(this.txtFilePath);
            this.grpOptions.Controls.Add(this.btnBrowse);
            this.grpOptions.Controls.Add(this.chkShowTray);
            this.grpOptions.Controls.Add(this.btnStop);
            this.grpOptions.Controls.Add(this.btnStart);
            this.grpOptions.Location = new System.Drawing.Point(12, 115);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(373, 77);
            this.grpOptions.TabIndex = 0;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Global Options";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Path:";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilePath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SimpleStreamTimer.Properties.Settings.Default, "filepath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtFilePath.Location = new System.Drawing.Point(63, 21);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(272, 20);
            this.txtFilePath.TabIndex = 1;
            this.txtFilePath.Text = global::SimpleStreamTimer.Properties.Settings.Default.filepath;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.AutoSize = true;
            this.btnBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBrowse.Location = new System.Drawing.Point(341, 19);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(26, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // chkShowTray
            // 
            this.chkShowTray.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkShowTray.AutoSize = true;
            this.chkShowTray.Checked = global::SimpleStreamTimer.Properties.Settings.Default.show_in_tray;
            this.chkShowTray.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowTray.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::SimpleStreamTimer.Properties.Settings.Default, "show_in_tray", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkShowTray.Location = new System.Drawing.Point(6, 54);
            this.chkShowTray.Name = "chkShowTray";
            this.chkShowTray.Size = new System.Drawing.Size(125, 17);
            this.chkShowTray.TabIndex = 3;
            this.chkShowTray.Text = "Show in System Tray";
            this.chkShowTray.UseVisualStyleBackColor = true;
            this.chkShowTray.CheckedChanged += new System.EventHandler(this.chkShowTray_CheckedChanged);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(227, 48);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(67, 23);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(300, 48);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(67, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.FileName = "countdown.txt";
            this.saveFileDialog1.Filter = "Text Files|*.txt|All Files|*.*\"";
            this.saveFileDialog1.InitialDirectory = "%USERPROFILE%\\Desktop";
            this.saveFileDialog1.OverwritePrompt = false;
            this.saveFileDialog1.RestoreDirectory = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedIndex", global::SimpleStreamTimer.Properties.Settings.Default, "selected_tab", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = global::SimpleStreamTimer.Properties.Settings.Default.selected_tab;
            this.tabControl1.Size = new System.Drawing.Size(397, 109);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.numHours);
            this.tabPage1.Controls.Add(this.lblTime);
            this.tabPage1.Controls.Add(this.chkShowHours);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.numMinutes);
            this.tabPage1.Controls.Add(this.numSeconds);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(389, 83);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Timer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 3);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(215, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Shows a countdown that lasts for a set time.";
            // 
            // numHours
            // 
            this.numHours.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::SimpleStreamTimer.Properties.Settings.Default, "timer_hours", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numHours.Location = new System.Drawing.Point(9, 32);
            this.numHours.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numHours.Name = "numHours";
            this.numHours.Size = new System.Drawing.Size(120, 20);
            this.numHours.TabIndex = 4;
            this.numHours.Value = global::SimpleStreamTimer.Properties.Settings.Default.timer_hours;
            this.numHours.ValueChanged += new System.EventHandler(this.num_ValueChanged);
            // 
            // lblTime
            // 
            this.lblTime.Location = new System.Drawing.Point(96, 55);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(288, 20);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "timer";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // chkShowHours
            // 
            this.chkShowHours.AutoCheck = false;
            this.chkShowHours.AutoSize = true;
            this.chkShowHours.Checked = global::SimpleStreamTimer.Properties.Settings.Default.show_hours;
            this.chkShowHours.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowHours.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::SimpleStreamTimer.Properties.Settings.Default, "show_hours", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkShowHours.Location = new System.Drawing.Point(6, 58);
            this.chkShowHours.Name = "chkShowHours";
            this.chkShowHours.Size = new System.Drawing.Size(84, 17);
            this.chkShowHours.TabIndex = 9;
            this.chkShowHours.Text = "Show Hours";
            this.chkShowHours.UseVisualStyleBackColor = true;
            this.chkShowHours.Click += new System.EventHandler(this.chkShowHours_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hours:";
            // 
            // numMinutes
            // 
            this.numMinutes.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::SimpleStreamTimer.Properties.Settings.Default, "timer_mins", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numMinutes.Location = new System.Drawing.Point(135, 32);
            this.numMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numMinutes.Name = "numMinutes";
            this.numMinutes.Size = new System.Drawing.Size(120, 20);
            this.numMinutes.TabIndex = 5;
            this.numMinutes.Value = global::SimpleStreamTimer.Properties.Settings.Default.timer_mins;
            this.numMinutes.ValueChanged += new System.EventHandler(this.num_ValueChanged);
            // 
            // numSeconds
            // 
            this.numSeconds.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::SimpleStreamTimer.Properties.Settings.Default, "timer_secs", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numSeconds.Location = new System.Drawing.Point(261, 32);
            this.numSeconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numSeconds.Name = "numSeconds";
            this.numSeconds.Size = new System.Drawing.Size(120, 20);
            this.numSeconds.TabIndex = 6;
            this.numSeconds.Value = global::SimpleStreamTimer.Properties.Settings.Default.timer_secs;
            this.numSeconds.ValueChanged += new System.EventHandler(this.num_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Minutes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Seconds:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblAlarm);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.TimePicker);
            this.tabPage2.Controls.Add(this.DatePicker);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(390, 92);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Alarm";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblAlarm
            // 
            this.lblAlarm.Location = new System.Drawing.Point(3, 54);
            this.lblAlarm.Name = "lblAlarm";
            this.lblAlarm.Size = new System.Drawing.Size(381, 21);
            this.lblAlarm.TabIndex = 5;
            this.lblAlarm.Text = "alarm time";
            this.lblAlarm.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Creates a countdown to a specific time and/or date.";
            // 
            // TimePicker
            // 
            this.TimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::SimpleStreamTimer.Properties.Settings.Default, "alarm_time", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePicker.Location = new System.Drawing.Point(45, 21);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.ShowUpDown = true;
            this.TimePicker.Size = new System.Drawing.Size(135, 20);
            this.TimePicker.TabIndex = 2;
            this.TimePicker.Value = global::SimpleStreamTimer.Properties.Settings.Default.alarm_time;
            this.TimePicker.ValueChanged += new System.EventHandler(this.TimePicker_ValueChanged);
            // 
            // DatePicker
            // 
            this.DatePicker.Checked = global::SimpleStreamTimer.Properties.Settings.Default.use_date;
            this.DatePicker.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::SimpleStreamTimer.Properties.Settings.Default, "use_date", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DatePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::SimpleStreamTimer.Properties.Settings.Default, "alarm_date", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePicker.Location = new System.Drawing.Point(186, 21);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.ShowCheckBox = true;
            this.DatePicker.Size = new System.Drawing.Size(135, 20);
            this.DatePicker.TabIndex = 0;
            this.DatePicker.Value = global::SimpleStreamTimer.Properties.Settings.Default.alarm_date;
            this.DatePicker.ValueChanged += new System.EventHandler(this.DatePicker_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 204);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Simple Timer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSeconds)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.CheckBox chkShowTray;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.NumericUpDown numHours;
        private System.Windows.Forms.NumericUpDown numMinutes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numSeconds;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkShowHours;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker TimePicker;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAlarm;
    }
}

