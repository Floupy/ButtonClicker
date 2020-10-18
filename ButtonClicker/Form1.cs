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
            StartGame();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainTimer.Start();
            MainProgressBar.Increment(10);
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
            if (MainProgressBar.Value == MainProgressBar.Maximum)
            {
                MainTimer.Stop();
                WinText.Enabled = true;
                WinText.Visible = true;
            }

        }

        private void ClickAmount10_Click(object sender, EventArgs e)
        {
            MainProgressBar.Minimum = (0);
            MainProgressBar.Maximum = (100);
            ClickAmount10.Enabled = false;
            ClickAmount25.Enabled = false;
            ClickAmount25.Visible = false;
            ClickAmount50.Enabled = false;
            ClickAmount50.Visible = false;
            MainButton.Enabled = true;



        }

        private void ClickAmount25_Click(object sender, EventArgs e)
        {
            MainProgressBar.Minimum = (0);
            MainProgressBar.Maximum = (250);
            ClickAmount10.Enabled = false;
            ClickAmount10.Visible = false;
            ClickAmount25.Enabled = false;
            ClickAmount50.Enabled = false;
            ClickAmount50.Visible = false;
            MainButton.Enabled = true;
        }

        private void ClickAmount50_Click(object sender, EventArgs e)
        {
            MainProgressBar.Minimum = (0);
            MainProgressBar.Maximum = (500);
            ClickAmount10.Enabled = false;
            ClickAmount10.Visible = false;
            ClickAmount25.Enabled = false;
            ClickAmount25.Visible = false;
            ClickAmount50.Enabled = false;
            MainButton.Enabled = true;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ClickAmount10.Visible = true;
            ClickAmount10.Enabled = true;
            ClickAmount25.Enabled = true;
            ClickAmount25.Visible = true;
            ClickAmount50.Enabled = true;
            ClickAmount50.Visible = true;
            dsec = sec = 0;
            UpdateClockDisplay();
            MainProgressBar.Value = (0);
            StartGame();

        }

        private void ClicksPerSecondStats()
        {
            


        }

        private void StartGame()
        {
            MainButton.Enabled = false;
            MainButton.Visible = false;
            MainProgressBar.Visible = false;
            MainProgressBar.Enabled = false;
            ClockDisplay.Enabled = false;
            ClockDisplay.Visible = false;
            WinText.Visible = false;
        }



    } }

