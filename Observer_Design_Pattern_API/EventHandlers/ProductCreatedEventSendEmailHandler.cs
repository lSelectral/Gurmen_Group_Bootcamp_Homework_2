using Observer_Design_Pattern_API.Events;
using Observer_Design_Pattern_API.Notifications;

namespace Observer_Design_Pattern_API.EventHandlers
{
    public class ProductCreatedEventSendEmailHandler : INotificationHandler
    {
        public void Update(INotification notification)
        {
            var product = notification as ProductCreatedEvent;
            Console.WriteLine($"Data from SMS Sender: {product.ProductName} with {product.Id} ID");
        }
    }
}