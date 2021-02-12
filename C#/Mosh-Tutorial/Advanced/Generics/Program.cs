using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new MyGenricList<string>();

            cars[0] = "Dodge";
            cars[1] = "Mercedes";
            cars[2] = "Audi";

            foreach ( string car in cars)
            {
                System.Console.WriteLine();
            }
        }
    }
}
