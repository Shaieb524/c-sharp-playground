using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ProblemSolving.Tasks.TaskNo2.Events.BankAccount
{
    // publisher class that raise events
    // declare delegates here to make accessable from other classes
    public delegate void TransactionHandler(object sender, TransactionEventArgs e);
    public class Account
    {
        public int Balance { get; set; }

        // define an event that depends on the delegate
        // this event invokes delegates when it is raised and subscribed to
        public event TransactionHandler TransactionMade;

        public Account(int balance)
        {
            Balance = balance;
        }

        // define notifying actions that will raise events 
        public void Debit(int debitAmount)
        {
            if (debitAmount < Balance)
            {
                Balance -= debitAmount;
                TransactionEventArgs e = new TransactionEventArgs(debitAmount, "Debited");
                OnTransactionMade(e); // Debit transaction made
            }
        }

        public void Credit(int creditAmount)
        {
            Balance += creditAmount;
            TransactionEventArgs e = new TransactionEventArgs(creditAmount, "Credited");
            OnTransactionMade(e); // Credit transaction made
        }

        protected virtual void OnTransactionMade(TransactionEventArgs e)
        {
            if (TransactionMade != null)
            {
                TransactionMade(this, e); // Raise the event (should be handled by subscribers)
            }
        }
    }
}
