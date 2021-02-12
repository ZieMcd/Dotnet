using System;

namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            var migrator = new DbMigrator(new Logger());
            var install = new Installer(new Logger());

            migrator.Migrate();
            install.Install();
        }
    }
}
