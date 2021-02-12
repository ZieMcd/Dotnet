using System;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace ConcurrentCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentDictionary<int,int> dic = new ConcurrentDictionary<int, int>(); //Program would throw error if we used normal dictionary

            Task tsk1 = Task.Run(() =>
            {
                for(int i = 0; i < 100; i++)
                {
                    dic.TryAdd(i,i+1);
                }
            });

            Task tsk2 = Task.Run(() =>
            {
                for(int i = 0; i < 100; i++)
                {
                    dic.TryAdd(i+1,i);
                }
            });

            Task[] allTasks = {tsk1,tsk2};
            Task.WaitAll(allTasks);

            System.Console.WriteLine("Program ran successfully");
        }
    }
}
