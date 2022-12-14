using Model;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class SeatService
    {
        private SeatRepository seatRepository = new SeatRepository();

        public void CreateSeat(Seat seat)
        {
            seatRepository.Create(seat);
        }
        public void UpdateSeat(Seat seat)
        {
            seatRepository.Update(seat);
        }
        public List<Seat> GetAllSeatsByShowTimeId(int showTimeId)
        {
            return seatRepository.GetAll(showTimeId);
        }
        public void CreateSeats(int ShowTimeId)
        {
            int numChar = 65;
            int posX = 300;
            int posY = 70;
            int dx = 40;
            int dy = 30;

            for (int i = 0; i < 15; i++)  //Rows
            {
                for (int j = 0; j < 15; j++) //Columns
                {
                    if (j == 1 || j == 12)
                    {
                        dx = 85;
                    }
                    else
                    {
                        dx = 40;
                    }
                    Seat seat = new Seat();                      //butaca = new Butaca();
                    seat.Flag = 1;                               //butaca.bandera = true;
                    seat.X = posX;                               //butaca.X = posX;
                    seat.Y = posY;                               //butaca.Y = posY;
                    seat.Status = "Desocupada";                  //butaca.EstadoButaca = EstadoButaca.DESOCUPADA;
                    seat.Letter = ((char)numChar).ToString();    //butaca.Letra = ((char)numChar).ToString();
                    seat.Number = (j + 1).ToString();            //butaca.Numero = (j + 1).ToString();
                    seat.ShowTimeId = ShowTimeId;
                    CreateSeat(seat);                            //butacas.Add(butaca);
                    posX = posX + dx;                            //posX = posX + dx;
                }
                posX = 300;
                posY = posY + dy;
                numChar++;
            }
        }
        public Seat GetSeatByXYSId(int X, int Y, int ShowTimeId)
        {
            return seatRepository.GetSeat(X, Y, ShowTimeId);
        }
    }
}
