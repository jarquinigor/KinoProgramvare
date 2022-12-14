using Model;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class OrderService
    {
        private OrderRepository orderRepository = new OrderRepository();

        public string CreateOrder(Order order)
        {
            return orderRepository.Create(order);
        }
        public List<Order> GetAllOrders()
        {
            return orderRepository.GetAll();
        }
    }
}
