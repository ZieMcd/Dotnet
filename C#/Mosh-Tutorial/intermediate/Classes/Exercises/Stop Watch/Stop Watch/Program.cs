using System;

namespace Stop_Watch
{
    class Program
    {
        static void Main(string[] args)
        {
            bool end = false;
            string line;
            var timer = new Time();

            Console.Write("Tpye START to Start: ");
            line = Console.ReadLine();

           if (line == "START")
           {
                timer.StartTimer();
           }

            Console.Write("Type STOP to stop: ");
            line = Console.ReadLine();

            if (line == "STOP")
            {
                timer.StopTimer();
            }

            Console.WriteLine(timer.TimeTot());

        }
    }
}
