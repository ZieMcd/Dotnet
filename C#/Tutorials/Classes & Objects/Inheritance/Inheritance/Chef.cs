using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Chef
    {
        public  void MakeChicken()
        {
            Console.WriteLine("The Chef makes chicken");
        }

        public void MakeSalad()
        {
            Console.WriteLine("The Chef makes chicken");
        }

        public virtual void MakeSpecial()  // put in virtual so you can change it (over-ride)
        {
            Console.WriteLine("The Chef makes bbq ribs");
        }

    }
}
