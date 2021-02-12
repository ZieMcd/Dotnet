using System;

namespace More_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 3, 7, 9, 3, 14, 6 };

            // length
            Console.WriteLine("Length of the arrayy: " + numbers.Length);

            // Index Of

            var index = Array.IndexOf(numbers, 9); // will return the place of the 9
            Console.WriteLine("Index of 9: " + index);

            // Clear()
            Array.Clear(numbers, 0, 2);

        }
    }
}
