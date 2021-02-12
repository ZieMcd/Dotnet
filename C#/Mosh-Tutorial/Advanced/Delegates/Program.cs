using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var proccessor = new PhotoProcessor();
            var fliter = new PhotoFilters();

            Action<Photo> filterHandler = fliter.ApplyBrightness;
            filterHandler += fliter.ApplyContrast;
            filterHandler += RemoveRedEye;
            
            proccessor.Process("pic.jpeg",filterHandler);
        }

        static void RemoveRedEye(Photo photo)
        {
            System.Console.WriteLine("Remove RedEye");
        }
    }
}
