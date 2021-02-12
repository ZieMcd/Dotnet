using System;
using System.IO;

namespace Working_with_file
{
    class Program
    {
        static void Main(string[] args)
        {
            // not much will work because the file does not exist but just pretend it does 


            //======using file
            var path = @"c:\somefile.jpg";

            File.Copy(path, @"c:whereToCopy", true);
            File.Delete(path); 

            if (File.Exists(path))
            {
                Console.WriteLine("it does");
            }

            var content = File.ReadAllText(path);


            //======using file Info

            var fileInfo = new FileInfo(path);

            fileInfo.CopyTo("new location");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {

            }


        }
    }
}
