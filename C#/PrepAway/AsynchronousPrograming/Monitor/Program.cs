using System;
using System.Threading;
using System.Threading.Tasks;

namespace Monitor
{
    class Program
    {
        private static object thislock = new object();
        static void Main(string[] args)
        {
            int num = 0;
            int lenght = 500000;

            Task tsk = Task.Run(()=> 
            {
                for (int i = 0; i < lenght; i++)
                {
                    Monitor.Enter(thislock);
                    num++;
                    Monitor.Exit(thislock);

                }
            });

             for (int i = 0; i < lenght; i++)
                {
                    Monitor.Enter(thislock);
                    num--;
                    Monitor.Exit(thislock);

                }
            tsk.Wait();
            System.Console.WriteLine(num);
        }
    }
}
