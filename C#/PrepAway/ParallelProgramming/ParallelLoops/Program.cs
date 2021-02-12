using System;
using System.Threading.Tasks;

namespace ParallelLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.For(1,5,(i)=>
            {
                System.Console.WriteLine(i);
            });

            
            System.Console.WriteLine("Next");


            int[] data = {1,2,3,4,5};
            Parallel.ForEach<int>(data, (d)=>
            {
                System.Console.WriteLine(d);
            });
        }
    }
}
