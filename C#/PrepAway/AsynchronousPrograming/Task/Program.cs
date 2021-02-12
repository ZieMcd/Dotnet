using System;
using System.Threading;
using System.Threading.Tasks;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Task myTask = new Task(myMethod);   //Task mytask = Task.Factory.StartNew(new Action(myMethod)); this will start task straight away so you dont need to call myTask.Start(); also it is faster
            myTask.Start();

            // Task runTask = Task.Run(() =>   // anthere way of making a task
            // {
            //     for (int i = 0; i < 20; i++)
            //     {
            //     System.Console.Write("O");
            //     }  
            // });


            myTask.Wait();

            System.Console.WriteLine("Done");

        }

        private static void myMethod()
        {
            for (int i = 0; i < 20; i++)
            {
                System.Console.Write("O");
            }
        }
    }
}
