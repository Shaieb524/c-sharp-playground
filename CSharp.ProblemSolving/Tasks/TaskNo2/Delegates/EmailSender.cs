
namespace CSharp.ProblemSolving.Tasks.TaskNo2.Delegates
{
    public class EmailSender
    {
        public string Title { get; set; }

        public int SendEmail()
        {
            Console.WriteLine("Doc was sent via Email");
            return 1;
        }
    }
}
