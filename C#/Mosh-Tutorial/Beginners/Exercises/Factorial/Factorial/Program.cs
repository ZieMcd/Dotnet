using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int num ;
            int ans = 1;

            Console.Write("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                ans = ans * i;
            }

            Console.WriteLine(ans);
        }
    }
}
