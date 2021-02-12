using System;

namespace Static_class_Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Song holyday = new Song("Holyday", "Green Day", 200);
            Console.WriteLine(Song.songCount);
            Song kashmir = new Song("Kashmir", "Zeppelin", 150);
            Console.WriteLine(Song.songCount);
        }
    }
}
