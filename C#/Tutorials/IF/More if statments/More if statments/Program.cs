using System;

namespace More_if_statments
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1, Num2, Num3;


            Console.Write("Enter first Num: ");
            Num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second Num: ");
            Num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter third Num: ");
            Num3 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(GetMax(Num1, Num2, Num3));


        }

        static int GetMax(int iNum1, int iNum2, int iNum3)
        {
            if (iNum1 >= iNum2 && iNum1 >= iNum3)
            {
                return iNum1;
            }
            else if (iNum2 > iNum1 && iNum2 > iNum3)
            {
                return iNum2;
            }
            else
            {
                return iNum3;
            }
           

        }


    }

    
}
