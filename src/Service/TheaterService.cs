using Model;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class TheaterService
    {
        private TheaterRepository theaterRepository = new TheaterRepository();

        public string CreateTheater(Theater theater)
        {
            return theaterRepository.Create(theater);
        }
        public List<Theater> GetAllTheaters()
        {
            return theaterRepository.GetAll();
        }
        public Theater GetTheaterByName(string name)
        {
            return theaterRepository.GetTheater(name);
        }
        public bool ExistsTheaterByName(string name)
        {
            return theaterRepository.ExistsTheater(name);
        }
    }
}
