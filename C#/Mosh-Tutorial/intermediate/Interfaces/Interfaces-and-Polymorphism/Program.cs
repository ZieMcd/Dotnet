using System;

namespace Interfaces_and_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var starWars = new Video();

            var encode = new VideoEncoder();
            encode.RegisterNotifficationChannel(new SmsChannel());
            encode.Encode(starWars);
        }
    }
}
