using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class TheaterRepository
    {
        public string Create(Theater theater)
        {
            using (var context = new DBEntities())
            {
                context.Theater.Add(theater);
                context.SaveChanges();
                return "Se registró una sala correctamente.";
            }
        }
        public List<Theater> GetAll()
        {
            DBEntities context = new DBEntities();
            return context.Theater.ToList<Theater>();
        }
        public Theater GetTheater(string name)
        {
            DBEntities context = new DBEntities();
            return context.Theater.Where(t => t.Name.Equals(name)).FirstOrDefault();
        }
        public bool ExistsTheater(string name)
        {
            DBEntities context = new DBEntities();
            if (context.Theater.Count(t => t.Name.Equals(name)) == 1)
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
