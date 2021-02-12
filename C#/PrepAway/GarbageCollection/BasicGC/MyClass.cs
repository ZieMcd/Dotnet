using System;
using System.Collections;
using System.IO;

namespace BasicGC
{
    public class MyClass : IDisposable
    {
        public StreamReader reader;
        
        public void Dispose()
        {
            if (reader != null)
                reader.Dispose();
        
        GC.SuppressFinalize(this);

        System.Console.WriteLine("Disposed");
        }
    }
}