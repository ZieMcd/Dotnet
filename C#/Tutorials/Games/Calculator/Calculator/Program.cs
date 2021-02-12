using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double iNum1, iNum2;
            string sOP;

            Console.Write("Enter a number: ");
            iNum1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter a operator: ");
            sOP = Console.ReadLine();

            Console.Write("Enter another number: ");
            iNum2 = Convert.ToDouble(Console.ReadLine());

            if (sOP == "+")
            {
                Console.WriteLine(iNum1 + iNum2);
            }else if (sOP == "-")
            {
                Console.WriteLine(iNum1 - iNum2);
            }else if (sOP == "*")
            {
                Console.WriteLine(iNum1 * iNum2);
            }else if (sOP == "/")
            {
                Console.WriteLine(iNum1 / iNum2);
            }else
            {
                Console.WriteLine("unknowen operator");
            }






        }
    }
}
