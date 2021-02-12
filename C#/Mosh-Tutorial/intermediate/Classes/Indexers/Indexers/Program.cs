using System;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpCookie cookie = new HttpCookie { Expiry = new DateTime(2020, 1, 1) };

            cookie["name"] = "Zie";
            cookie["age"] = "19";

            Console.WriteLine("Name: "+ cookie["name"]+"\nAge: "+ cookie["age"]+"\nExpiry: " + cookie.Expiry);
        }
    }
}
