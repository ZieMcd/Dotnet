using System;

namespace Tutorial_1
{
    class Program
    {
 
        static void Main(string[] args)
        {
            int iNum;

            string[] arrNames = { "zie", "jack" };
            string[] arrSrt = new string[3];

            Console.Write("Enter a number: ");
            iNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Cube(iNum));

            Console.WriteLine(arrNames[1]);


        }

        static void SayHi(string sName, int iAge)
        {
            Console.WriteLine("Hello "+ sName + " you are "+ iAge + " years old ");
        }


        static int Cube(int num)
        {
 
            return num * num * num;
        }


    }
}
