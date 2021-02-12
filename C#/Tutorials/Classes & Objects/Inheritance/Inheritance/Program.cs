using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Chef chef1 = new Chef();
            chef1.MakeSpecial();

            ItalianChef italianChef1 = new ItalianChef();
            italianChef1.MakeSpecial();


        }
    }
}
