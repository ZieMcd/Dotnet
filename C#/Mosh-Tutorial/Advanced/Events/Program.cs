 using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Tittle = "Video 1" };
            var videoEncoder = new VideoEncoder(); //publisher
            var mailService = new MailService(); //subscriber
            var smsService = new SmsService(); //subscriber

            
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += smsService.OnvideoEncoded;
            
            videoEncoder.Encode(video);
        }
    }
}
