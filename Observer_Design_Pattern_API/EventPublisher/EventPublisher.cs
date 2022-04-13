using Observer_Design_Pattern_API.Notifications;

namespace Observer_Design_Pattern_API.EventPublisher
{
    public class EventPublisher : IEventPublisher
    {
        public List<INotificationHandler> _notificationHandlers = new List<INotificationHandler>();

        public void Publish(INotification notification)
        {
            Console.WriteLine("Publishing message to listeners");
            foreach (INotificationHandler handler in _notificationHandlers)
            {
                handler.Update(notification);
            }
        }

        public void Subscribe(INotificationHandler notificationHandler)
        {
            Console.WriteLine("Subscribing the listener");
            _notificationHandlers.Add(notificationHandler);
        }

        public void Unsubscribe(INotificationHandler notificationHandler)
        {
            Console.WriteLine("Unsubscribing the listener");
            if (_notificationHandlers.Contains(notificationHandler))
                _notificationHandlers.Remove(notificationHandler);
        }
    }
}