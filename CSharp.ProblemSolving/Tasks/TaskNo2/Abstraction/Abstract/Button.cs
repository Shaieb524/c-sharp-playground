using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ProblemSolving.Tasks.TaskNo2.Abstraction.Abstract
{
    // in order button to be concrete class, it must implement DrawMe abstract method
    public class Button : Control
    {
        // we dont want anyone to set the contents property except for the constructor 
        // so we put set as private
        public string Contents { get; private set; }

        public Button(int top, int left, string contents) :
            base(top, left)
        {
            Contents = contents;
        }

        public override void DrawMe()
        {
            Console.WriteLine(Contents);
            Console.WriteLine("I am at : {0} {1}", top, left);
        }
    }
}
