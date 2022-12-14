using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class CustomerRepository
    {
        public string Create(Customer customer)
        {
            using (var context = new DBEntities())
            {
                context.Customer.Add(customer);
                context.SaveChanges();
                return "Se registró un cliente correctamente.";
            }
        }
        public void Update(Customer customer)
        {
            DBEntities context = new DBEntities();
            context.Entry(customer).State = EntityState.Modified;
            context.SaveChanges();
        }
        public List<Customer> GetAll()
        {
            DBEntities context = new DBEntities();
            return context.Customer.ToList<Customer>();
        }
        public Customer GetCustomer(string dni)
        {
            DBEntities context = new DBEntities();
            return context.Customer.Where(c => c.dni.Equals(dni)).FirstOrDefault();
        }
        public bool ExistsCustomer(string dni)
        {
            DBEntities context = new DBEntities();
            if (context.Customer.Count(c => c.dni.Equals(dni)) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
