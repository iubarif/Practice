using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDelegate
{
    public class VideoEncoder
    {

        //public delegate void VideoEncodedEventHandler(object source, ViderEventArg e);

        public EventHandler<ViderEventArg> VidioEncoded;

        //public event VideoEncodedEventHandler VidioEncoded;
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video ....");
            System.Threading.Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if (VidioEncoded != null)
            {
                VidioEncoded(this, new ViderEventArg() { video = video });
            }
        }
    }

    public class ViderEventArg : EventArgs
    {
        public Video video { get; set; }
    }
}
