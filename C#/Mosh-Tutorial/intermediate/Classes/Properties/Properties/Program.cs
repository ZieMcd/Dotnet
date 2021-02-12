using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Person me = new Person(new DateTime(1982, 1, 1));

            

            Console.WriteLine(me.Age);
        }
    }
}
