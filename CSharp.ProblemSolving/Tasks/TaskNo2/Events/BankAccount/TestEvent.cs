using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ProblemSolving.Tasks.TaskNo2.Events.BankAccount
{
    public class TestEvent
    {
        public static void SendNotification(object sender, TransactionEventArgs e)
        {
            Console.WriteLine("You have been {0} with {1}", e.TransactionType, e.TransactionAmout);
        }
        public static void Main()
        {
            Account acc = new Account(1000);
            acc.TransactionMade += new TransactionHandler(SendNotification);
            acc.Credit(500);
            Console.WriteLine("Your current account is {0}", acc.Balance);
        }
    }
}
