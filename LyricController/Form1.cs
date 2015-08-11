using MinimalisticTelnet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LyricController
{
    public partial class Form1 : Form
    {
        //TelnetConnection Lyric = new TelnetConnection("127.0.0.1", 23);
        
        clockControl gameClock = new clockControl();        

        public Form1()
        {
            InitializeComponent();

            mainTimer.Interval = 1000;
            clockTiming.Text = "1000 milliseconds";
            updateClockForm();
            
        }

        #region Clock Functions

        private void adjustClockShow_Click(object sender, EventArgs e)
        {
            if (adjustClockShow.Text == "Adjust Clock")
            {
                clockTiming.Visible = true;
                clockAdjustBar.Visible = true;
                adjustClockShow.Text = "Hide";
            }
            else
            {
                clockTiming.Visible = false;
                clockAdjustBar.Visible = false;
                adjustClockShow.Text = "Adjust Clock";
            }

        }

        private void clockAdjustBar_Scroll(object sender, ScrollEventArgs e)
        {
            mainTimer.Interval = clockAdjustBar.Value;
            clockTiming.Text = mainTimer.Interval + " milliseconds";
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            if ((gameClock.Seconds == 0) && (gameClock.Minutes == 0))
            {
                mainTimer.Enabled = false;
                clockStartStop.Text = "Start";
            }
            else
            {
                gameClock.clockTick();
                updateClockForm();
            }
        }

        private void updateClockForm()
        {
            if ((gameClock.Minutes == 0) && (gameClock.Seconds == 0))
            {
                mainTimer.Enabled = false;
                clockStartStop.Text = "Start";
            }
            clockMinutes.Text = gameClock.Minutes > 9 ? clockMinutes.Text = gameClock.Minutes.ToString("D2").TrimStart('0') : gameClock.Minutes.ToString("D0").TrimStart('0');
            clockSeconds.Text = gameClock.Seconds.ToString("D2");
        }

        private void clockMinutes_KeyUp(object sender, EventArgs e)
        {
            if (!mainTimer.Enabled)
            {
                try
                {
                    if (!String.IsNullOrEmpty(clockMinutes.Text))
                    {
                        gameClock.Minutes = Convert.ToInt32(clockMinutes.Text);
                        gameClock.clockInputChanged();
                    }
                }
                catch
                {
                    MessageBox.Show("Clock Error");
                }
            }
        }

        private void clockSeconds_KeyUp(object sender, EventArgs e)
        {
            if (!mainTimer.Enabled)
            {
                try
                {
                    gameClock.Seconds = Convert.ToInt32(clockSeconds.Text);
                    gameClock.clockInputChanged();
                }
                catch
                {
                    MessageBox.Show("Clock Error");
                }
            }
        }

        private void clockStartStop_Click(object sender, EventArgs e)
        {
            if (clockStartStop.Text == "Start")
            {
                if ((gameClock.Minutes == 0) && (gameClock.Seconds == 0))
                {
                    //do nothing - prevents clock from being accidentally started
                    //while both values are zero
                }
                else
                {
                    mainTimer.Enabled = true;
                    clockStartStop.Text = "Stop";
                }
            }
            else
            {
                mainTimer.Enabled = false;
                clockStartStop.Text = "Start";
            }
        }

        private void clockUp_Click(object sender, EventArgs e)
        {
            gameClock.updateClock(1);
            updateClockForm();
        }

        private void clockDown_Click(object sender, EventArgs e)
        {
            gameClock.updateClock(-1);
            updateClockForm();
        }

        #endregion



    }
}
