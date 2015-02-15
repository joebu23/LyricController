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

        public string strMinutes { get; set; }
        public string strSeconds { get; set; }

        public TimeSpan gameTimer { get; set; }

        public clockControl()
        {
            this.Minutes = 20;
            this.Seconds = 00;
            this.strMinutes = "20";
            this.strSeconds = "00";
            this.gameTimer = new TimeSpan(0, Minutes, Seconds);
        }

        public void clockReset()
        {
            this.Minutes = 20;
            this.Seconds = 00;
            this.strMinutes = "20";
            this.strSeconds = "00";
            this.gameTimer = new TimeSpan(0, Minutes, Seconds);
        }

        public void clockInputChanged()
        {
            gameTimer = new TimeSpan(0, Minutes, Seconds);
            strMinutes = Minutes.ToString();
            if (gameTimer.Seconds < 10)
            {
                strSeconds = "0" + gameTimer.Seconds.ToString();
            }
            else
            {
                strSeconds = gameTimer.Seconds.ToString();
            }
        }

        public void clockTick()
        {
            TimeSpan span = new TimeSpan(0,0,1);
            gameTimer = gameTimer.Subtract(span);
            Minutes = gameTimer.Minutes;
            strMinutes = gameTimer.Minutes.ToString();
            Seconds = gameTimer.Seconds;
            if (gameTimer.Seconds < 10)
            {
                strSeconds = "0" + gameTimer.Seconds.ToString();
            }
            else
            {
                strSeconds = gameTimer.Seconds.ToString();
            }
        }

        public void updateClock(int change)
        {
            // added comment to test git hub updating
            TimeSpan span = new TimeSpan(0,0,change);
            gameTimer = gameTimer.Add(span);
            Minutes = gameTimer.Minutes;
            strMinutes = gameTimer.Minutes.ToString();
            Seconds = gameTimer.Seconds;
            if (Seconds < 10)
            {
                strSeconds = "0" + gameTimer.Seconds.ToString();
            }
            else
            {
                strSeconds = gameTimer.Seconds.ToString();
            }
            
        }

    }
}
