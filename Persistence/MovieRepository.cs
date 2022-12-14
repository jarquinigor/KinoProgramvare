using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class MovieRepository
    {
        public string Create(Movie movie)
        {
            using (var context = new DBEntities())
            {
                context.Movie.Add(movie);
                context.SaveChanges();
                return "Se registró una película correctamente.";
            }
        }
        public List<Movie> GetAll()
        {
            DBEntities context = new DBEntities();
            return context.Movie.ToList<Movie>();
        }
        public Movie GetMovie(string name)
        {
            DBEntities context = new DBEntities();
            return context.Movie.Where(m => m.Name.Equals(name)).FirstOrDefault();
        }
        public bool ExistsMovie(string name)
        {
            DBEntities context = new DBEntities();
            if (context.Movie.Count(m => m.Name.Equals(name)) == 1)
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
