using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ProblemSolving.Tasks.TaskNo2.Abstraction.Interfaces
{
    public class Document : Printable, Storable
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public void Print()
        {
            Console.WriteLine("Document 1");
        }

        public int Status()
        {
            return 0;
        }

        public void Read()
        {
            Console.WriteLine("Reading Document 1");
        }

        public string Write()
        {
            return "abc";
        }
    }
}
