using System;
using System.Threading;
using System.Threading.Tasks;

namespace ChildTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Task outer = new Task(()=>
            {
                System.Console.WriteLine("Outer Task");

                Task inner = new Task(()=>
                {
                    System.Console.WriteLine("Inner Task");
                    Thread.Sleep(100);      
                },TaskCreationOptions.AttachedToParent); // TaskCreationOptions.AttachedToParent, parrent task(outer) cant terminate with out all attatched classes are complete

                inner.Start();

                Thread.Sleep(100);
            });

            outer.Start();
            outer.Wait();
        }
    }
}
