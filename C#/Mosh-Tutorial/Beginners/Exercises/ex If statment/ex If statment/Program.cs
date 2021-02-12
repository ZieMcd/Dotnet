using System;

namespace ex_If_statment
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 9;
            int height = 8;

            Console.WriteLine(Shape(length, height));
        }


        static string Shape(int l,int h)
        {
            if (l > h)
            {
                return "Lanscape";
            }
            else if (h > l)
            {
                return "Portrait";
            }
            else
            {
                return "sqaure";
            }
        }
    }
}
