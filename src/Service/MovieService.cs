using Model;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class MovieService
    {
        private MovieRepository movieRepository = new MovieRepository();

        public string CreateMovie(Movie movie)
        {
            return movieRepository.Create(movie);
        }
        public List<Movie> GetAllMovies()
        {
            return movieRepository.GetAll();
        }
        public Movie GetMovieByName(string name)
        {
            return movieRepository.GetMovie(name);
        }
        public bool ExistsMovieByName(string name)
        {
            return movieRepository.ExistsMovie(name);
        }
    }
}
