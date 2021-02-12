using System;

namespace If_Staments
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isMale = false;
            bool isTall = true;

            if (isMale && isTall)  // && is AND, || is OR
            {
                Console.WriteLine("you are tall male");

            } else if (!isMale && isTall )
            {
                Console.WriteLine("you are tall female");
            }
        }
    }
}
