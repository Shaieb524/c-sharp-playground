
namespace CSharp.ProblemSolving.Tasks.TaskNo2.Delegates
{
    public class Document
    {
        public delegate int SendDoc();
        public string Text { get; set; }

        public void DocumentSender(SendDoc sendDoc)
        {
            if (sendDoc() == 0)
                Console.WriteLine("Sending document failed!");
            else
                Console.WriteLine("Document was sent!");
        }

    }
}
