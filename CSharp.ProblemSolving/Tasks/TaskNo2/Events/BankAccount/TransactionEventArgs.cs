using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ProblemSolving.Tasks.TaskNo2.Events.BankAccount
{
    // we instantiate this class to pass data to subscriber class
    public class TransactionEventArgs : EventArgs
    {
        public int TransactionAmout { get; set; }
        public string TransactionType { get; set; }

        public TransactionEventArgs(int tAmount, string tType)
        {
            TransactionAmout = tAmount;
            TransactionType = tType;
        }
    }
}
