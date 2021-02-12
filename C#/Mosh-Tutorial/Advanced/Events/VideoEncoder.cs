using System;
using System.Threading;

namespace Events
{
    public class VideoEncoder
    {
        // 1- Define delegate 
        // 2- Define an event based on that delegate
        // 3- Raise the event

        //public delegate void VideoEncoderEventHandler(object source, VideoEventArgs args);
        public event EventHandler<VideoEventArgs> VideoEncoded;
        public void Encode(Video video)
        {
            System.Console.WriteLine("Encoding Video");
            
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs(){Video = video});
        }
    }
}