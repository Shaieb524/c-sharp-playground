

namespace CSharp.ProblemSolving.Tasks.TaskNo2.Taskk
{
    public class MainConsole
    {
        public static void Main()
        {
            Helper.DrawVerticalLine(5);

            StarEmitter emitter = new StarEmitter();
            ConsoleDrawer cD = new ConsoleDrawer();

            cD.Subscribe(emitter);
            emitter.EmitStars().GetAwaiter().GetResult();

        }

    }
}
