using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class SeatRepository
    {
        public void Create(Seat seat)
        {
            using (var context = new DBEntities())
            {
                context.Seat.Add(seat);
                context.SaveChanges();
            }
        }
        public List<Seat> GetAll(int showTimeId)
        {
            DBEntities context = new DBEntities();
            return context.Seat.Where(s => s.ShowTimeId == showTimeId).ToList<Seat>();
        }
        public void Update(Seat seat)
        {
            DBEntities context = new DBEntities();
            context.Entry(seat).State = EntityState.Modified;
            context.SaveChanges();
        }
        public Seat GetSeat(int X, int Y, int ShowTimeId)
        {
            DBEntities context = new DBEntities();
            return context.Seat.Where(s => s.X == X && s.Y == Y && s.ShowTimeId == ShowTimeId).FirstOrDefault();
        }
    }
}
