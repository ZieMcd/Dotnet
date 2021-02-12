using System;

namespace BasicGC
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MyClass obj = new MyClass()) // Dispose is automatically called in using statement
            {

            }

            MyClass obj2 = null;

            try
            {
                obj2 = new MyClass();
            }
            finally
            {
                obj2.Dispose(); // or you call Dispose in try catch block 
            }
        }
    }
}
