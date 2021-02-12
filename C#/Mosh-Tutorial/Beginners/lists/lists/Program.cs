using System.Collections.Generic;
using System;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {

            var nums = new List<int>() { 1, 2, 3, 4 };

            nums.Add(1);
            nums.AddRange(new int[3] {5, 6, 7 });

            foreach ( var num in nums)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine();
            Console.WriteLine("Index of 1: "+ nums.IndexOf(1));
            Console.WriteLine("Last Index of 1: " + nums.LastIndexOf(1));

            Console.WriteLine();
            Console.WriteLine("Count: "+nums.Count);

            Console.WriteLine();

            //nums.Remove(1);

            for (int i = 0; i <nums.Count; i++)
            {
                if (nums[i] == 1) 
                {
                    nums.Remove(nums[i]);
                }
            }

            foreach (var num in nums)
            {
                Console.WriteLine(num);
            }

            //nums.clear                     removes everything in the list


        }
    }
}
