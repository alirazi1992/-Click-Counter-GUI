using System;
using System.Windows.Forms;

namespace ClickCounterGUI
{
    public partial class Form1 : Form
    {
        // --- state ---
        private int _count = 0;
        private int _clicksThisSecond = 0;  // for CPS
        private int _streak = 0;            // fun stat
        private int _bestCps = 0;

        public Form1()
        {
            InitializeComponent();          // ✅ constructor only here (not in Designer!)

            // Initial UI
            lblCount.Text = "Count: 0";
            lblCps.Text = "CPS: 0 (best 0)";
            lblStreak.Text = "Streak: 0";
            progress.Value = 0;

            // Timer setup (1 second ticks)
            timer.Interval = 1000;
            timer.Start();
        }

        // CLICK! button
        private void btnClick_Click(object sender, EventArgs e)
        {
            _count++;
            _clicksThisSecond++;
            _streak++;

            lblCount.Text = "Count: " + _count;
            lblStreak.Text = "Streak: " + _streak;

            int next = progress.Value + 5;
            progress.Value = next > 100 ? 100 : next;

            if (chkSound.Checked)
                System.Media.SystemSounds.Beep.Play();
        }

        // Reset button
        private void btnReset_Click(object sender, EventArgs e)
        {
            _count = 0;
            _clicksThisSecond = 0;
            _streak = 0;

            lblCount.Text = "Count: 0";
            lblCps.Text = "CPS: 0 (best " + _bestCps + ")";
            lblStreak.Text = "Streak: 0";
            progress.Value = 0;
        }

        // Checkbox (optional – we just read Checked in btnClick_Click)
        private void chkSound_CheckedChanged(object sender, EventArgs e)
        {
            // no body required
        }

        // Timer tick every 1 second: update CPS & decay progress
        private void timer_Tick(object sender, EventArgs e)
        {
            if (_clicksThisSecond > _bestCps) _bestCps = _clicksThisSecond;
            lblCps.Text = "CPS: " + _clicksThisSecond + " (best " + _bestCps + ")";
            _clicksThisSecond = 0;

            if (progress.Value > 0)
            {
                int next = progress.Value - 8;
                progress.Value = next < 0 ? 0 : next;
            }
            else
            {
                if (_streak > 0) _streak = 0;
                lblStreak.Text = "Streak: " + _streak;
            }
        }
    }
}
