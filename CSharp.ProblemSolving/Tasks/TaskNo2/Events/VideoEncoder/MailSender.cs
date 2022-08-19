using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ProblemSolving.Tasks.TaskNo2.Events.VideoEncoder
{
    public class MailSender
    {
        // here we have to define event handler that complies to the publisher delegate
        public void SendEmail(object sender, EventArgs e)
        {
            Console.WriteLine("Sending an email");
        }
    }
}
