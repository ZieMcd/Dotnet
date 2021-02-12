using System;

namespace MoreGenrics
{
    class Program
    {

        // where T : IComparable        -> has Implemented an interface 
        // where T : Product            -> is a class
        // where T : sturct             -> is value type
        // where T : class              -> is referance type
        // where T : new()              -> obeject has default constuctor 
        static void Main(string[] args)
        {
            Console.WriteLine(Max<int>(7,4));



        }

        public static T Max<T> (T a, T b) where T : IComparable
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}
