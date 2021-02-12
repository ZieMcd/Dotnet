using System.Collections.Generic;

namespace Interfaces_and_Polymorphism
{
    public class VideoEncoder
    {
        private readonly IList<INotificationChannel> _notifications;
        public VideoEncoder()
        {
            _notifications = new List<INotificationChannel>();
        }
        public void Encode(Video video)
        {
            //video encodeing logic

            foreach (var channel in _notifications)
            {
                channel.Send(new Message());
            }
        }

        public void RegisterNotifficationChannel(INotificationChannel channel)
        {
            _notifications.Add(channel);
        }
    }
}