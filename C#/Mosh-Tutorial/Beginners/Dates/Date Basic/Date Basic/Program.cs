using System;

namespace Date_Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2015, 8, 2);
            var now = DateTime.Now;
            var today = DateTime.Today;

            //Console.WriteLine(now.Hour);
            //Console.WriteLine(now.Minute);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());

            Console.WriteLine(now.ToString("dddd"));






        }
    }
}
