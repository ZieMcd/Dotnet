using System;
using System.Threading;
using System.Threading.Tasks;

namespace ContinueWith
{
    class Program
    {
        static void Main(string[] args)
        {
            Task tsk1 = Task.Run(()=>
            {
                Thread.Sleep(100);
                System.Console.WriteLine("tsk1");
            });

            Task tsk2 = tsk1.ContinueWith((t)=>
            {
                Thread.Sleep(100);
                System.Console.WriteLine("tsk2");
            });

            tsk2.Wait();


            Task<string> tskA = Task.Run(()=>
            {
                Thread.Sleep(100);
                return "John";
            });

            Task tskB = tskA.ContinueWith((t)=>
            {
                string name = t.Result;
                System.Console.WriteLine(name);
            });

            tskB.Wait();

        }
    }
}
