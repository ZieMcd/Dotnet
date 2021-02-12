namespace Extensibility.app
{
    public class ConsoleLogger : ILogger
    {
        public void LogError(string message)
        {
            System.Console.ForegroundColor = System.ConsoleColor.Red;
            System.Console.WriteLine(message);
        }

        public void LogInfo(string message)
        {
            System.Console.ForegroundColor = System.ConsoleColor.Green;
            System.Console.WriteLine(message);
        }
    }
}