using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 001" };
            var videoEncoder = new VideoEncoder();  //Publisher
            var mailService = new MailService();  //Subscriber  
            var messageService = new MessageService();


            videoEncoder.VidioEncoded += mailService.OnVideoEncoded;
            videoEncoder.VidioEncoded += messageService.OnVideoEncoded;

            videoEncoder.Encode(video);

            Console.ReadLine();
        }

       
    }

    public class MailService
    {
        public void OnVideoEncoded(object source, ViderEventArg e)
        {            
            Console.WriteLine("MailService: Sending an Email ...Title : {0}", e.video.Title);
        }
    }

    public class MessageService
    {
        public void OnVideoEncoded(object source, ViderEventArg e)
        {
            Console.WriteLine("MessageService: Sending an Text message...: {0}", e.video.Title);
        }
    }
}
