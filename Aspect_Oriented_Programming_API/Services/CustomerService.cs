using Aspect_Oriented_Programming_API.Models;

namespace Aspect_Oriented_Programming_API.Services
{
    public class CustomerService : ICustomerService
    {
        private static List<Customer> _customerList = new List<Customer>()
        {
            new Customer()
            {
                Id = 1,
                Name = "Watney",
                Age = 24,
                Email = "watney@hotmail.com",
            },
            new Customer()
            {
                Id=2,
                Name = "Alphonso",
                Age= 15,
                Email = "alphonso.edward@hotmail.com"
            }
        };
        public List<Customer> GetCustomers()
        {
            return _customerList;
        }

        public Customer GetCustomerById(int id)
        {
            return _customerList.Where(x => x.Id == id).SingleOrDefault();
        }

        public void AddCustomer(CustomerInsertCommandModel customer)
        {
            _customerList.Add(new Customer() { Name = customer.Name, Age = customer.Age, Email = customer.Email});
        }

        public void UpdateCustomer(Customer customer)
        {
            var c = _customerList.Where(x => x.Id == customer.Id).SingleOrDefault();
            _customerList[_customerList.IndexOf(c)] = customer;
        }
        public void DeleteCustomer(int id)
        {
            _customerList.Remove(_customerList.Where(x => x.Id == id).SingleOrDefault());
        }
    }
}
