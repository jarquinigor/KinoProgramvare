using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class Order_SnackRepository
    {
        public void Create(Order_Snack order_Snack)
        {
            using (var context = new DBEntities())
            {
                context.Order_Snack.Add(order_Snack);
                context.SaveChanges();
            }
        }
    }
}
