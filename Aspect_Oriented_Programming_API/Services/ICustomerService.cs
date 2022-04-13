using Aspect_Oriented_Programming_API.Models;

namespace Aspect_Oriented_Programming_API.Services
{
    public interface ICustomerService
    {
        public List<Customer> GetCustomers();
        public Customer GetCustomerById(int id);
        public void AddCustomer(Customer customer);
        public void UpdateCustomer(Customer customer);
        public void DeleteCustomer(int id);
    }
}
