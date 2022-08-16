using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ProblemSolving.Tasks.TaskNo2.Events.VideoEncoder
{
    public class CustomConsole
    {
        public static void Main()
        {
            VideoEncoder videoEncoder = new VideoEncoder();
            
            MailSender mailSender = new MailSender();
            MessageSender messageSender = new MessageSender();

            videoEncoder.OnVideoEncoded += new VideoEncoder.VideoEncodingEventHandler(mailSender.SendEmail);
            videoEncoder.OnVideoEncoded += new VideoEncoder.VideoEncodingEventHandler(messageSender.SendMessage);

            videoEncoder.ProcessVideo();
            // now we register list of subscribed handlers in delegate

        }
    }
}
