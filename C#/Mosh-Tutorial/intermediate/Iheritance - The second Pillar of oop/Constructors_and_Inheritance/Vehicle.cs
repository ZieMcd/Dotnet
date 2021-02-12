using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors_and_Inheritance
{
    class Vehicle
    {
        private readonly string _regNuber; 
        public Vehicle(string regNum)
        {
            Console.WriteLine("Creating Vehicle"+regNum);
            _regNuber = regNum;
        }
    }
}
