
namespace CSharp.ProblemSolving.Tasks.TaskNo2.Taskk
{
    public class ConsoleDrawer
    {
        public void Subscribe(StarEmitter emitter)
        {
            emitter.StarEmitted += new StarEmitter.EmittedStarHandler(DrawAStar);
        }

        public void DrawAStar(object sender, CustomEventArgs e)
        {
            Console.WriteLine("*  {0}:{1}:{2}",
                e.Hour.ToString(),
                e.Minute.ToString(),
                e.Second.ToString()
                );
        }
    }
}
