
namespace CSharp.ProblemSolving.Tasks.TaskNo2.Taskk
{
    public class StarEmitter
    {
        public delegate void EmittedStarHandler(object sender, CustomEventArgs e);

        public delegate string EmittedStarWPFHandler(object sender, EventArgs e);

        public event EmittedStarHandler StarEmitted;

        public event EmittedStarWPFHandler StarEmittedWPF;

        public int ColumnLength { get; set; }

        public int TimeInterval { get; set; }

        public StarEmitter(int columnLength, int timeInterval)
        {
            ColumnLength = columnLength;
            TimeInterval = timeInterval;
        }

        public void DrawVerticalLine()
        {
            Console.WriteLine("Line 1 : ");
            for (int i = 0; i < ColumnLength; i++)
            {
                Console.WriteLine("*");
            }
        }

        public string DrawVerticalLineString()
        {
            string result = "Line 1 : \n";
            for (int i = 0; i < ColumnLength; i++)
            {
                result += "* \n";
            }
            return result;
        }

        public async Task EmitStars()
        {
            var periodicTimer = new PeriodicTimer(TimeSpan.FromSeconds(TimeInterval));
            var counter = 0;
            Console.WriteLine("Line 2 : ");

            while (await periodicTimer.WaitForNextTickAsync() && counter < ColumnLength)
            {
                var currentTime = DateTime.Now;

                CustomEventArgs e = new CustomEventArgs()
                {
                    Second = currentTime.Second,
                    Minute = currentTime.Minute,
                    Hour = currentTime.Hour
                };

                if (StarEmitted != null)
                {
                    StarEmitted(this, e);
                }

                if (StarEmittedWPF != null)
                {
                    StarEmittedWPF(this, e);
                }

                counter++;
            }

            Console.WriteLine("End..");
        }
    }
}
