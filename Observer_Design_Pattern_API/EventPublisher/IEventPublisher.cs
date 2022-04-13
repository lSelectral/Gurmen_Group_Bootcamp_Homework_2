using Observer_Design_Pattern_API.Notifications;

namespace Observer_Design_Pattern_API.EventPublisher
{
    public interface IEventPublisher
    {
        public void Subscribe(INotificationHandler notificationHandler);
        public void Unsubscribe(INotificationHandler notificationHandler);
        public void Publish(INotification notification);
    }
}