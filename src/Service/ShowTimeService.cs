using Model;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ShowTimeService
    {
        private ShowTimeRepository showTimeRepository = new ShowTimeRepository();

        public string CreateShowTime(ShowTime showTime)
        {
            return showTimeRepository.Create(showTime);
        }
        public List<ShowTime> GetShowTimesByTheaterId(int TheaterId)
        {
            return showTimeRepository.GetAll(TheaterId);
        }
        public List<ShowTime> GetShowTimesByMovieId(int MovieId)
        {
            return showTimeRepository.GetAllByMovieId(MovieId);
        }
        public ShowTime GetShowTimeById(int ShowTimeId)
        {
            return showTimeRepository.GetShowTime(ShowTimeId);
        }
    }
}
