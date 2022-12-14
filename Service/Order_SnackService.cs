using Model;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class Order_SnackService
    {
        private Order_SnackRepository Order_SnackRepository = new Order_SnackRepository();

        public void CreateOrder_Snack(Order_Snack order_Snack)
        {
            Order_SnackRepository.Create(order_Snack);
        }
    }
}
