using Observer_Design_Pattern_API.Notifications;

namespace Observer_Design_Pattern_API.Events
{
    public class ProductCreatedEvent : INotification
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
    }
}
