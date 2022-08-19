using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ProblemSolving.Tasks.TaskNo2.Events.Clock
{
    public class CustomConsole
    {
        public static void Main()
        {
            Clock clock = new Clock();
            Logger logger = new Logger();
            VisibleClock clockVisible = new VisibleClock();

            logger.Subscribe(clock);
            clockVisible.Subscribe(clock);
            clock.RunClock();

        }
    } 
}
