using System;

namespace Events
{
    public class SmsService
    {
        public void OnvideoEncoded(object source,VideoEventArgs e)
        {
            System.Console.WriteLine("Sendong sms..."+e.Video.Tittle);
        }
    }
}