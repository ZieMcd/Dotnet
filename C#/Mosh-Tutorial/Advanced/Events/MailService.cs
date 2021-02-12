using System;

namespace Events
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            System.Console.WriteLine("Sending email..." + e.Video.Tittle);
        }

        
        
    }
}