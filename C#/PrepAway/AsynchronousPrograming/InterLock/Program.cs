using System;
using System.Threading;
using System.Threading.Tasks;

namespace InterLock
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int lenght = 500000;

            Task tsk = Task.Run(()=>
            {
                for (int i = 0; i < lenght; i++)
                {
                    InterLock.Increment(ref num);  //thinks its windows thing mabye?
                }
            });

            for (int i = 0; i < lenght; i++)
                {
                    InterLock.Decrement(ref num);  //thinks its windows thing mabye?
                }

            tsk.Wait();
            
            System.Console.WriteLine(num);
        }
    }
}
