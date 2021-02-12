using System;
using System.Text;

namespace String_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder();
            builder.Append('=',10);
            builder.AppendLine();
            builder.Append("Hello");
            builder.AppendLine();
            builder.Append('=', 10);


            Console.WriteLine(builder);
        }
    }
}
