using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ProblemSolving.Tasks.TaskNo2.Events.VideoEncoder
{
    public class VideoEncoder
    {

        public delegate void VideoEncodingEventHandler(object sender, EventArgs e);

        public event VideoEncodingEventHandler OnVideoEncoded;

        public void ProcessVideo()
        {
            Console.WriteLine("Video is being processed...");
            Thread.Sleep(1000);
            OnVideoEncodedDone();
        }

        protected virtual void OnVideoEncodedDone()
        {
            if (OnVideoEncoded != null)
            {
                OnVideoEncoded(this, EventArgs.Empty);
            }
        }
    }
}
