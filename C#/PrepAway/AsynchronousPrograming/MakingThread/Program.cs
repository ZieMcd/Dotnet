using System;
using System.Threading;
using System.Threading.Tasks;

namespace MakingThread
{
    class Program
    {
        static void Main(string[] args)
        {

            Thread t = new Thread(WriteO);
            t.Start();

            for (int i  = 0; i < 1000 ; i++)
            {
                System.Console.Write(".");
            }
        }

        static void WriteO()
        { 
            for (int i = 0; i < 1000 ; i++)
            {
                System.Console.Write("O");
            }           
        }
    }
}
