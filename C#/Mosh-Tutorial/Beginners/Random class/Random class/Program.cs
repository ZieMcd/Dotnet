using System;

namespace Random_class
{
    class Program
    {
        static void Main(string[] args)
        {
            var randomNum = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine((char)randomNum.Next(97,122));
            }

        }
    }
}
