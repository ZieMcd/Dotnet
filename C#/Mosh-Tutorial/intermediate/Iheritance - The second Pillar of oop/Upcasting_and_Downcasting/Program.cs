using System;


namespace Upcasting_and_Downcasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Text text = new Text();
            Shape shape = text;

            text.Width = 100;

            System.Console.WriteLine(text.Width);
        }
    }
}
