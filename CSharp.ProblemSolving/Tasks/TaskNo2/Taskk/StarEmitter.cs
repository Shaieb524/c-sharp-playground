
namespace CSharp.ProblemSolving.Tasks.TaskNo2.Taskk
{
    public class StarEmitter
    {
        public delegate void EmittedStarHandler(object sender, CustomEventArgs e);

        public event EmittedStarHandler StarEmitted;

        public int TimeInterval { get; set; }
        public int LineLength { get; set; }

        public StarEmitter(int lineLength, int timeInterval)
        {
            LineLength = lineLength;
            TimeInterval = timeInterval;
        }

        public void DrawVerticalLine()
        {
            Console.WriteLine("Line 1 : ");
            for (int i = 0; i < LineLength; i++)
            {
                Console.WriteLine("*");
            }
        }

        public async Task EmitStars()
        {
            var periodicTimer = new PeriodicTimer(TimeSpan.FromSeconds(TimeInterval));

            Console.WriteLine("Line 2 : ");

            while (await periodicTimer.WaitForNextTickAsync())
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
            }
        }


    }
}
