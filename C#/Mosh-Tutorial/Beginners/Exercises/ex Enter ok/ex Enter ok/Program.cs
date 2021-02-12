using System;

namespace ex_Enter_ok
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;
            string word = null;

            while (flag != true)
            {
                Console.Write("Enter OK: ");
                word = Console.ReadLine();      

                if (word == "OK")
                {
                    Console.WriteLine("Well done");
                    flag = true;
                }
            }
        }
    }
}
