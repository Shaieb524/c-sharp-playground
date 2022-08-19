

namespace CSharp.ProblemSolving.Tasks.TaskNo2.Taskk
{
    public class MainConsole
    {
        public static void Main()
        {

            StarEmitter emitter = new StarEmitter(5, 3);
            emitter.DrawVerticalLine();

            ConsoleDrawer cD = new ConsoleDrawer();

            cD.Subscribe(emitter);
            emitter.EmitStars().GetAwaiter().GetResult();

        }

    }
}
