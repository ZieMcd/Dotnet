using System;

namespace Extensibility.app
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new FileLogger("//home"));

            dbMigrator.Migrate();
            Console.WriteLine("Hello World!");
        }
    }
}
