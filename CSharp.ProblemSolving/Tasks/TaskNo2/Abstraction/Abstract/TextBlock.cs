using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ProblemSolving.Tasks.TaskNo2.Abstraction.Abstract
{
    public class TextBlock : Control
    {
        public string Text { get; private set; }

        public TextBlock(int top, int left, string text) :
            base(top, left)
        {
            Text = text;
        }

        public override void DrawMe()
        {
            Console.WriteLine(Text);
            Console.WriteLine("I am at : {0} {1}", top, left);
        }
    }
}
