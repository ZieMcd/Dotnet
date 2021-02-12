
using System;

namespace _5_unique_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[5];

            bool flag = false;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter a Number: ");
                nums[i] = Convert.ToInt32(Console.ReadLine());

                for (int g = 0; g < i; g++)
                {
                    if (nums[i] == nums[g])
                    {
                        Console.WriteLine("same number entered");
                        while (nums[i] == nums[g])
                        {
                            Console.Write("please re-enter number: ");
                            nums[i] = Convert.ToInt32(Console.ReadLine());
                        }
                    } 


                }


               
            }

            foreach (var num in nums)
                {
                    Console.WriteLine(num);
                }


        }
    }
}
