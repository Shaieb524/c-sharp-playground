using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ProblemSolving.Tasks.TaskNo2.Models
{
    public class Manager : Employee
    {

        public Manager(string name, string street, string city, int region) :
            this(name, street, city, region, 9000)
        { }
        
        public Manager(string name, string street, string city, int region, double salary) :
            base(name, street, city, region, salary) // pass properties up to the base
        { } 

        public override string DoWork()
        {
            return "Manager does work";
        }

        public override string DoWork(string msg)
        {
            return msg + msg;
        }
    }
}
