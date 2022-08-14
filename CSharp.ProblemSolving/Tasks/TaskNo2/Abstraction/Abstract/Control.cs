using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ProblemSolving.Tasks.TaskNo2.Abstraction.Abstract
{
    public abstract class Control
    {
        protected int top;
        protected int left;

        public Control(int top, int left)
        {
            this.top = top;
            this.left = left;
        }

        // Default constructor passes default values to the other constructor
        public Control() :
            this(0, 0)
        { }

        public abstract void DrawMe();

    }
}
