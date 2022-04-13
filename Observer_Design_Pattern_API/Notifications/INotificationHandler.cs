namespace Observer_Design_Pattern_API.Notifications
{
    public interface INotificationHandler
    {
        void Update(INotification notification);
    }
}