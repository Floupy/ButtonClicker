using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonClicker
{
    public partial class Form1 : Form
    {
        int dsec = 0;
        int sec = 0;
        int min = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainTimer.Start();
            this.MainProgressBar.Increment(10);
            ProgressBarComplete();
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            dsec += 1;
            if (dsec == 100)
            {
                sec += 1;
                dsec = 0;

            }
            if (sec == 60)
            {
                min += 1;
                sec = 0;

            }
            UpdateClockDisplay();
        }
        private void UpdateClockDisplay()
        {
            string timeText;
            timeText = min.ToString("00") + ":";
            timeText += sec.ToString("00") + ":";
            timeText += dsec.ToString("00");
            ClockDisplay.Text = timeText;

        }
        private void ProgressBarComplete()
        {
            if(MainProgressBar.Value == MainProgressBar.Maximum)
            {
                MainTimer.Stop();
                WinText.ForeColor = Color.Black;
            }
            
            
            {

            }
            

            
            
        }

        private void ClickAmount10_Click(object sender, EventArgs e)
        {
            MainProgressBar.Minimum = (0);
            MainProgressBar.Maximum = (100);
            
            
        }

        private void ClickAmount25_Click(object sender, EventArgs e)
        {
            MainProgressBar.Minimum = (0);
            MainProgressBar.Maximum = (250);
        }

        private void ClickAmount50_Click(object sender, EventArgs e)
        {
            MainProgressBar.Minimum = (0);
            MainProgressBar.Maximum = (500);
        }
    }
}
