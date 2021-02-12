using System;
using System.Threading;
using System.Threading.Tasks;


namespace CancellationToken
{
    class Program
    {
        static void Main(string[] args)
        {
            CancellationTokenSource source = new CancellationTokenSource();

            CancellationToken token = source.Token;

            Task tsk = Task.Run(()=>
            {
                System.Console.WriteLine("hello from tsk1");
                while(true)
                {
                    Thread.Sleep(1000);

                    System.Console.WriteLine("*");

                    if(token.IsCacellationRequseted == true)
                    {
                        System.Console.WriteLine("Bye from tsk");
                        return;
                    }
                }
            },token);

            System.Console.WriteLine("Hello from main thread");

            Thread.Sleep(100);

            source.Cancel();

        }

       
    }
}
