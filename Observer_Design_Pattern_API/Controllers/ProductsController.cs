using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Observer_Design_Pattern_API.EventHandlers;
using Observer_Design_Pattern_API.EventPublisher;
using Observer_Design_Pattern_API.Events;
using Observer_Design_Pattern_API.Models;

namespace Observer_Design_Pattern_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IEventPublisher _eventPublisher;

        public ProductsController(IEventPublisher eventPublisher)
        {
            _eventPublisher = eventPublisher;
        }

        [HttpPost]
        public void AddData(Product product)
        {
            _eventPublisher.Subscribe(new ProductCreatedEventSendEmailHandler());
            _eventPublisher.Subscribe(new ProductCreatedEventSendSMSHandler());

            _eventPublisher.Publish(new ProductCreatedEvent() { Id = product.Id, ProductName = product.Name });
        }
    }
}