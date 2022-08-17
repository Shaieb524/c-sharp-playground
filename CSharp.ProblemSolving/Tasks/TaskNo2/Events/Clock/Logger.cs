using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ProblemSolving.Tasks.TaskNo2.Events.Clock
{
    public class Logger
    {
        public void Subscribe(Clock theClock)
        {
            // to you delegate's set of subscriptions a new TimeChangedHandler
            theClock.TimeChanged += new Clock.TimeChangedHandler(TimePassed);
        }

        public void TimePassed(object sender, TimeEventArgs e)
        {
            Console.WriteLine("Loggin event at : {0}:{1}:{2}",
                    e.Hour.ToString(),
                    e.Minute.ToString(),
                    e.Second.ToString()
                ); ;
        }
    }
}
