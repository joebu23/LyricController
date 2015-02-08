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
        TelnetConnection Lyric = new TelnetConnection("127.0.0.1", 23);
        
        clockControl GameClock = new clockControl("15", "00");
        

        public Form1()
        {
            InitializeComponent();

            gameTimer.Interval = 1000;
            clockTiming.Text = "1000 milliseconds";
            updateFormClock();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Lyric.Login("joe", "royston5051", 10000);
            Console.Write(Lyric.Read());

            Lyric.WriteLine("joe");
            //MessageBox.Show("hi");
            //Console.Write("hi");
            //while (tc.IsConnected && prompt.Trim() != "exit")
            //{
            //    // display server output
            Console.Write(Lyric.Read());

            Lyric.WriteLine("dir");
            Console.Write(Lyric.Read());

            //    // send client input to server
            //    prompt = Console.ReadLine();
            //    tc.WriteLine(prompt);

            //    // display server output
            //    Console.Write(tc.Read());
            //}
        }

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
            gameTimer.Interval = clockAdjustBar.Value;
            clockTiming.Text = gameTimer.Interval + " milliseconds";
        }

        private void clockStartStop_Click(object sender, EventArgs e)
        {
            if (clockStartStop.Text == "Start")
            {
                gameTimer.Enabled = true;
                clockStartStop.Text = "Stop";
            }
            else
            {
                gameTimer.Enabled = false;
                clockStartStop.Text = "Start";
            }
            
        }

        private void updateFormClock()
        {
            clockMinutes.Text = GameClock.strMinutes;
            clockSeconds.Text = GameClock.strSeconds;
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            GameClock.clockTick();
            updateFormClock();
        }

        private void clockUp_Click(object sender, EventArgs e)
        {
            GameClock.updateClock(1);
            updateFormClock();
        }

        private void clockDown_Click(object sender, EventArgs e)
        {
            GameClock.updateClock(-1);
            updateFormClock();
        }
    }
}
