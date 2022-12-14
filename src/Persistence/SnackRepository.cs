using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class SnackRepository
    {
        public string Create(Snack snack)
        {
            using (var context = new DBEntities())
            {
                context.Snack.Add(snack);
                context.SaveChanges();
                return "Se registró un snack correctamente.";
            }
        }
        public List<Snack> GetAll()
        {
            DBEntities context = new DBEntities();
            return context.Snack.ToList<Snack>();
        }
        public Snack GetSnack(int SnackId)
        {
            DBEntities context = new DBEntities();
            return context.Snack.Where(s => s.SnackId == SnackId).FirstOrDefault();
        }
        public int GetSnackId(string Name, string Size)
        {
            DBEntities context = new DBEntities();
            return context.Snack.Where(s => s.Name.Equals(Name) && s.Size.Equals(Size)).FirstOrDefault().SnackId;
        }
        public bool ExistsSnack(string Name, string Size)
        {
            DBEntities context = new DBEntities();
            if (context.Snack.Count(c => c.Name.Equals(Name) && c.Size.Equals(Size)) == 1)
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
