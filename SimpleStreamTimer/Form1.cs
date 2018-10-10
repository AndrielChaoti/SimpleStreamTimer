using System;
using System.IO;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace SimpleStreamTimer {
    public partial class Form1 : Form {
        DateTime countdownStarted = new DateTime();
        TimeSpan countdown = new TimeSpan();
        bool isCounting = false;

        public Form1() {
            InitializeComponent();
        }

        private void chkShowTray_CheckedChanged(object sender, EventArgs e) {
            notifyIcon1.Visible = chkShowTray.Checked;
            //Properties.Settings.Default.show_in_tray = chkShowTray.Checked;
        }

        private void Form1_Load(object sender, EventArgs e) {
            //chkShowTray.Checked = Properties.Settings.Default.show_in_tray;
            notifyIcon1.Icon = Properties.Resources.clock_face;
            notifyIcon1.Visible = chkShowTray.Checked;

            string filepath = Properties.Settings.Default.filepath;
            if (filepath == "") {
                filepath = Environment.ExpandEnvironmentVariables("%userprofile%\\Desktop\\countdown.txt");
            }
            txtFilePath.Text = filepath;

            //numHours.Value = Properties.Settings.Default.timer_hours;
            //numMinutes.Value = Properties.Settings.Default.timer_mins;
            //numSeconds.Value = Properties.Settings.Default.timer_secs;
            countdown = TimeSpan.FromHours((double)numHours.Value) + TimeSpan.FromMinutes((double)numMinutes.Value) + TimeSpan.FromSeconds((double)numSeconds.Value);
            if (chkShowHours.Checked) {
                lblTime.Text = "Current Timer: " + countdown.ToString(@"h\:mm\:ss");
            }
            else {
                lblTime.Text = "Current Timer: " + countdown.ToString(@"m\:ss");
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            Properties.Settings.Default.Save();

            notifyIcon1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e) {

            if (numHours.Value == 0 && numMinutes.Value == 0 && numSeconds.Value == 0) {
                MessageBox.Show("Can't start a countdown with no time!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            countdown = TimeSpan.Zero;
            countdownStarted = DateTime.Now;
            countdown = TimeSpan.FromHours((double)numHours.Value) + TimeSpan.FromMinutes((double)numMinutes.Value) + TimeSpan.FromSeconds((double)numSeconds.Value);

            toggleCountdown(true);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            //Properties.Settings.Default.timer_hours = numHours.Value;
            //Properties.Settings.Default.timer_mins = numMinutes.Value;
            //Properties.Settings.Default.timer_secs = numSeconds.Value;
            //Properties.Settings.Default.filepath = txtFilePath.Text;

            if (isCounting) {
                DialogResult result = MessageBox.Show("The timer is still running, are you sure you want to exit?",
                    "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.No) {
                    e.Cancel = true;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e) {
            if (!isCounting) toggleCountdown(false);
            TimeSpan currentValue = countdown - TimeSpan.FromTicks(DateTime.Now.Ticks - countdownStarted.Ticks);
            if (currentValue <= TimeSpan.Zero) {
                toggleCountdown(false);
                currentValue = TimeSpan.Zero;
                if (chkShowTray.Checked) {
                    notifyIcon1.BalloonTipText = "Countdown has finished.";
                    notifyIcon1.BalloonTipTitle = "Simple Countdown";
                    notifyIcon1.ShowBalloonTip(5000);
                }
            }
            try {

                if (chkShowHours.Checked) {
                    lblTime.Text = "Current Timer: " + currentValue.ToString(@"h\:mm\:ss");
                    File.WriteAllText(txtFilePath.Text, currentValue.ToString(@"h\:mm\:ss"));
                }
                else {
                    lblTime.Text = "Current Timer: " + currentValue.ToString(@"m\:ss");
                    File.WriteAllText(txtFilePath.Text, currentValue.ToString(@"m\:ss"));
                }
            }
            catch (Exception ex) {
                MessageBox.Show("An error occured! See details\n" +
                    ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                toggleCountdown(false);
            }
        }

        private void btnStop_Click(object sender, EventArgs e) {
            toggleCountdown(false);
        }

        private void toggleCountdown(bool mode) {
            numHours.Enabled = !mode;
            numMinutes.Enabled = !mode;
            numSeconds.Enabled = !mode;
            txtFilePath.Enabled = !mode;
            btnBrowse.Enabled = !mode;

            btnStop.Enabled = mode;
            btnStart.Enabled = !mode;
            timer1.Enabled = mode;
            isCounting = mode;
        }

        private void btnBrowse_Click(object sender, EventArgs e) {
            DialogResult result = saveFileDialog1.ShowDialog(ActiveForm);
            if (result != DialogResult.OK) {
                return;
            }
            txtFilePath.Text = saveFileDialog1.FileName;
        }

        private void num_ValueChanged(object sender, EventArgs e) {
            countdown = TimeSpan.FromHours((double)numHours.Value) + TimeSpan.FromMinutes((double)numMinutes.Value) + TimeSpan.FromSeconds((double)numSeconds.Value);
            if (chkShowHours.Checked) {
                lblTime.Text = "Current Timer: " + countdown.ToString(@"h\:mm\:ss");
            }
            else {
                lblTime.Text = "Current Timer: " + countdown.ToString(@"m\:ss");
            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e) {
            WindowState = FormWindowState.Normal;
            Activate();
        }

        private void Form1_Resize(object sender, EventArgs e) {
            if (WindowState == FormWindowState.Minimized && chkShowTray.Checked) {
                ShowInTaskbar = false;
            }
            else {
                ShowInTaskbar = true;
            }
        }

        private void chkShowHours_CheckedChanged(object sender, EventArgs e) {
            if (chkShowHours.Checked) {
                lblTime.Text = "Current Timer: " + countdown.ToString(@"h\:mm\:ss");
            }
            else {
                lblTime.Text = "Current Timer: " + countdown.ToString(@"m\:ss");
            }
        }
    }
}
