
namespace CSharp.ProblemSolving.Tasks.TaskNo2.Taskk
{
    public class Helper
    {
        public static void DrawVerticalLine(int lineLength)
        {
            Console.WriteLine("Line 1 : ");
            for (int i = 0; i < lineLength; i++)
            {
                Console.WriteLine("*");
            }
        }

        // TODO pass action as delegate
        public static async Task ActionWithTimer(int seconds, int endLoopIndex)
        {
            Console.WriteLine("Line 2 :");
            var periodicTimer = new PeriodicTimer(TimeSpan.FromSeconds(seconds));
            var coutner = 1;

            while (await periodicTimer.WaitForNextTickAsync())
            {
                Console.WriteLine("*");
            }
  
        }
    }
}
