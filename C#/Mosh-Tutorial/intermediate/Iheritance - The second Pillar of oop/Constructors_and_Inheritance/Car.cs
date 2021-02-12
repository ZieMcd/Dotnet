using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors_and_Inheritance
{
    class Car: Vehicle
    {
        public Car(string regNum)
            :base(regNum)
        {
            Console.WriteLine("Creating car"+regNum);
        }
    }
}
