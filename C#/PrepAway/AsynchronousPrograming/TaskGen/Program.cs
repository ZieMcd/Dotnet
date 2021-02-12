using System;
using System.Threading;
using System.Threading.Tasks;

namespace TaskGen
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> myTask = new Task<int>(myMehod);   //Task<int> myTask = new Task<int>.Factory.StartNew<int>(myMethod);     if you do it like this you doknt have to .Start
            myTask.Start();                              //Task<int> myTask = Task.Run<int>(new Func<int>(myMethod));
            
            // var myTask2 =Task.Run<int>(()=>
            // {
            //     return 10;
            // });


            System.Console.WriteLine("Hello from foregroun thread");
            
            int i = myTask.Result;

            System.Console.WriteLine("Task has returned " + i);
        }

        static int myMehod()
        {
            Console.WriteLine("Getting from different thread");
            Thread.Sleep(100);
            return 10;
        }
    }
}
