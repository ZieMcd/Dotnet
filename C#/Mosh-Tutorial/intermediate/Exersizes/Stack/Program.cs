using System;
using System.Collections.Generic;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var thing1 = new stack();

            thing1.Push(1);
            thing1.Push(4);

            System.Console.WriteLine(thing1.Pop());
        }
    }
}
