using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class OrderRepository
    {
        public string Create(Order order)
        {
            using (var context = new DBEntities())
            {
                context.Order.Add(order);
                context.SaveChanges();
                return "Se realizó una compra satisfactoriamente.";
            }
        }
        public List<Order> GetAll()
        {
            DBEntities context = new DBEntities();
            return context.Order.ToList<Order>();
        }
    }
}
