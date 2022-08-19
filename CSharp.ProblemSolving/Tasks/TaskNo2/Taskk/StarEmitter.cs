
namespace CSharp.ProblemSolving.Tasks.TaskNo2.Taskk
{
    public class StarEmitter
    {
        public delegate void EmittedStarHandler(object sender, CustomEventArgs e);

        public event EmittedStarHandler StarEmitted;

        public int TimeInterval { get; set; }

        public async Task EmitStars()
        {
            var periodicTimer = new PeriodicTimer(TimeSpan.FromSeconds(3));

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
