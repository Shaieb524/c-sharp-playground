
namespace CSharp.ProblemSolving.Tasks.TaskNo2.Taskk
{
    public class ConsoleDrawer
    {
        public int ColumnLength { get; set; }

        public ConsoleDrawer(int columnLenth)
        {
            ColumnLength = columnLenth;
        }

        public void Subscribe(StarEmitter emitter)
        {
            emitter.StarEmitted += new StarEmitter.EmittedStarHandler(DrawAStar);
        }

        public string SubscribeWPF(StarEmitter emitter)
        {
            emitter.StarEmittedWPF += new StarEmitter.EmittedStarWPFHandler(DrawAStarString);
            return "*";
        }

        public void DrawAStar(object sender, CustomEventArgs e)
        {
            Console.WriteLine("*  {0}:{1}:{2}",
                e.Hour.ToString(),
                e.Minute.ToString(),
                e.Second.ToString()
                );

            ClearCurrentConsoleLine(ColumnLength); 
        }

        public string DrawAStarString(object sender, EventArgs e)
        {
            string line = "* ";
            return line;
        }

        public static void ClearCurrentConsoleLine(int columnLenth)
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop-(columnLenth + 2));
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }
    }
}
