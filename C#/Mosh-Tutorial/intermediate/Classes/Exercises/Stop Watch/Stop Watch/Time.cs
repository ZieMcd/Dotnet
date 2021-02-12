using System;
using System.Collections.Generic;
using System.Text;

namespace Stop_Watch
{
    class Time
    {
        public DateTime TimeStart { get; private set; }
        public DateTime TimeEnd { get; private set; }


        public void StartTimer()
        {
            TimeStart = DateTime.Now;
        }

        public void StopTimer()
        {
            TimeEnd = DateTime.Now;
        }

        public float TimeTot()
        {
            return (TimeEnd - TimeStart).Seconds;
        }


    }
}
