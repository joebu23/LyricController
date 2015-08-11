using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyricController
{
    public class clockControl
    {
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public TimeSpan gameTimer { get; set; }

        public clockControl()
        {
            this.Minutes = 20;
            this.Seconds = 00;
            this.gameTimer = new TimeSpan(0, Minutes, Seconds);
        }

        public void clockReset()
        {
            this.Minutes = 20;
            this.Seconds = 00;
            this.gameTimer = new TimeSpan(0, Minutes, Seconds);
        }

        public void clockInputChanged()
        {
            gameTimer = new TimeSpan(0, Minutes, Seconds);
        }

        public void clockTick()
        {
            TimeSpan span = new TimeSpan(0,0,1);
            gameTimer = gameTimer.Subtract(span);
            Minutes = gameTimer.Minutes;
            Seconds = gameTimer.Seconds;
        }

        public void updateClock(int change)
        {
            TimeSpan span = new TimeSpan(0,0,change);
            gameTimer = gameTimer.Add(span);
            Minutes = gameTimer.Minutes;
            Seconds = gameTimer.Seconds;
        }

    }
}
