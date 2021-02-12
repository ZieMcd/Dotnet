using System;

namespace Exponent_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int baseNum, expoNum;

            Console.Write("Enter base: ");
            baseNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter base : ");
            expoNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Expo(baseNum,expoNum));
        }

        static double Expo(int iBase, int iExpo) 
            {
            Double dAnswer = iBase;

            for (int i=1; i < iExpo; i++)
            {
                dAnswer = dAnswer * iBase;
            }

            return dAnswer;
            }
    }
}
