using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class ItalianChef : Chef            //Itaian chef can do everthing a normal chef can,  ItalianChef is sub class
    {
        public void MakePasta()
        {
            Console.WriteLine("Chef makes pasta");
        }

        public override void MakeSpecial()  //  override makes it so we can change the method for italian chef
        {
            Console.WriteLine("The Chef makes chicken parm");
        }

    }
}
