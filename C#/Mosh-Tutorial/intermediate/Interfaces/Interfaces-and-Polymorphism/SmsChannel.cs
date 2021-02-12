namespace Interfaces_and_Polymorphism
{
    public class SmsChannel:INotificationChannel
    {
        public void Send(Message message)
        {
            System.Console.WriteLine("Sending sms...");
        }
    }
}