using System;
using System.Linq;

namespace PLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = Enumerable.Range(1,50);

            var plinq = from d in data.AsParallel()
                        where d % 10 == 0
                        select d;

            foreach (var item in plinq)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
