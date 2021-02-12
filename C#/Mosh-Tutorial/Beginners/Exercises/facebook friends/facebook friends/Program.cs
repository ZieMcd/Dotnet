using System;

namespace facebook_friends
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = null;
            int counter = -1;
            do
            {
                Console.Write("Enter friend name: ");
                name = Console.ReadLine();
                counter++;
            } while (name != "");

            Console.WriteLine("You have "+counter+" facebook friends");
        }
    }
}
