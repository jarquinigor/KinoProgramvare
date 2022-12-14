using Model;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class CustomerService
    {
        private CustomerRepository customerRepository = new CustomerRepository();

        public string CreateCustomer(Customer customer)
        {
            return customerRepository.Create(customer);
        }
        public void Update(Customer customer)
        {
            customerRepository.Update(customer);
        }
        public List<Customer> GetAllCustomers()
        {
            return customerRepository.GetAll();
        }
        public Customer GetCustomerByDni(string dni)
        {
            return customerRepository.GetCustomer(dni);
        }
        public bool ExistsCustomerByDni(string dni)
        {
            return customerRepository.ExistsCustomer(dni);
        }
    }
}
