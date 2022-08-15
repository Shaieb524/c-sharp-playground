
namespace CSharp.ProblemSolving.Tasks.TaskNo2.Delegates
{
    public class PostBlog
    {
        public string Address { get; set; }

        public int DeliverPost()
        {
            Console.WriteLine("Document was delivered!");
            return 1;
        }
    }
}
