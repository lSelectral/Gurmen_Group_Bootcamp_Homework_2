using Aspect_Oriented_Programming_API.Models;
using Aspect_Oriented_Programming_API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Aspect_Oriented_Programming_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public List<Customer> GetCustomers()
        {
            return _customerService.GetCustomers();
        }

        [HttpGet("{id}")]
        public Customer GetCustomerById(int id)
        {
            return _customerService.GetCustomerById(id);
        }

        [HttpPost]
        public void AddCustomer(CustomerInsertCommandModel customer)
        {
            _customerService.AddCustomer(customer);
        }

        [HttpPut]
        public void UpdateCustomer(Customer customer)
        {
            _customerService.UpdateCustomer(customer);
        }

        [HttpDelete("{id}")]
        public void DeleteCustomer(int id)
        {
            _customerService.DeleteCustomer(id);
        }
    }
}
