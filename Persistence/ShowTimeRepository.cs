using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class ShowTimeRepository
    {
        public string Create(ShowTime showTime)
        {
            using (var context = new DBEntities())
            {
                context.ShowTime.Add(showTime);
                context.SaveChanges();
                return "Se registró un horario correctamente.";
            }
        }
        public List<ShowTime> GetAll(int TheaterId)
        {
            DBEntities context = new DBEntities();
            return context.ShowTime.Where(s => s.TheaterId == TheaterId).ToList<ShowTime>();
        }
        public List<ShowTime> GetAllByMovieId(int MovieId)
        {
            DBEntities context = new DBEntities();
            return context.ShowTime.Where(s => s.MovieId == MovieId).ToList<ShowTime>();
        }
        public ShowTime GetShowTime(int ShowTimeId)
        {
            DBEntities context = new DBEntities();
            return context.ShowTime.Where(s => s.ShowTimeId == ShowTimeId).FirstOrDefault();
        }
    }
}
