using System;
using System.Net;
using System.IO;

namespace WebReqeust_WebResponse
{
    class Program
    {
        static void Main(string[] args)
        {
            WebRequest request = WebRequest.Create("http://www.almox.com");
            WebResponse response = request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream());

            string result = reader.ReadToEnd();

            System.Console.WriteLine(result);
            response.Close();
        }
    }
}
