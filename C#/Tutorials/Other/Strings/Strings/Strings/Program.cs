using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string fistName = "Zie";
            string lastName = "McDowell";

            string fullName = fistName + " " + lastName; // not best way to do it 

            string myFullName = string.Format("My name is {0} {1}", fistName, lastName); // best way to do it 
            //Console.WriteLine(myFullName);



            var names = new string[3] { "John", "Mark", "Zie" };

            string formatArray = string.Join(",", names);
            //Console.WriteLine(formatArray);

            string text = @"folder/class/nice  
you can also skip lines";

            Console.WriteLine(text);


            

        }
    }
}
