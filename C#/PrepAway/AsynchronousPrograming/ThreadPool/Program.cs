using System;
using System.Threading;

namespace Thread_Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(ThreadProc));

            System.Console.WriteLine("From Main Thread");

            System.Console.ReadKey();

            ThreadPool.QueueUserWorkItem((s) => {
                System.Console.WriteLine("Anothere free thread from thread pool");
            });

            Console.ReadKey();
        }

        static void ThreadProc(Object info)
        {
            System.Console.WriteLine(("thread pool"));
        }
    }
}
