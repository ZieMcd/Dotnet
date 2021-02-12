using System;
using System.Threading;
using System.Threading.Tasks;

namespace TaskContinuationOption
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<string> tsk1 = Task.Run(()=>
            {
                throw new Exception();

                Console.WriteLine("tsk1 ran");
                Thread.Sleep(100);
                return "John";
            });

            Task tsk2 = tsk1.ContinueWith((t)=>
            {
                System.Console.WriteLine("tsk2 ran if task 1 threw an Expection");
            }, TaskContinuationOptions.OnlyOnFaulted); // OnlyOnFaulted : tskB will only execuite if tskA threw an exception.

            tsk2.Wait();
        }
    }
}
