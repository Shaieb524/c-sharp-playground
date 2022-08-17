using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ProblemSolving.Tasks.TaskNo2.Events.Clock
{
    public class Clock
    {
        private int Second;
        private int Minute;
        private int Hour;

        public delegate void TimeChangedHandler(object sender, TimeEventArgs e);
        
        public event TimeChangedHandler TimeChanged;

        public void RunClock()
        {
            while (true)
            {
                Thread.Sleep(100);
                var currentTime = DateTime.Now;

                if (currentTime.Second != this.Second)
                {
                    // if time passed, create new TimeEvent args to pass to the delegate
                    TimeEventArgs e = new TimeEventArgs()
                    {
                        Second = currentTime.Second,
                        Minute = currentTime.Minute,
                        Hour = currentTime.Hour
                    };

                    // check for subscriptions with the delegate
                    if (TimeChanged != null)
                    {
                        // raise the event
                        TimeChanged(this, e);
                    }

                    // update time
                    this.Second = currentTime.Second;
                    this.Minute = currentTime.Minute;
                    this.Hour = currentTime.Hour;
                }
                
            }
        }
    }
}
