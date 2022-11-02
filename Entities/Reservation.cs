using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Entities
{
    class Reservation
    {
        public int RoomNumer { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        { 
        }

        public Reservation(int roomNumer, DateTime checkIn, DateTime checkOut)
        {
            RoomNumer = roomNumer;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public string UpdateDates(DateTime checkIn, DateTime checkOut) // Função que recebe as datas e atualiza as reservas
        {
            DateTime now = DateTime.Now; // Pega a data com um instante atual
            if (checkIn < now || checkOut < now)
            {
                 return "Error in reservation: Reservation dates for update must be future dates";
            }

            // Falata testar a data de saída se é maior que a data de entrada
            if (checkOut <= checkIn)
            {
                return "Erro in reservation: check-out date be after check-in date";   // return corta o else então somente if será considerado
            }


            CheckIn = checkIn;
            CheckOut = checkOut;
            return null;   // significa que nao treve nenhum erro
        }

        public override string ToString()
        {
            return "Room "
                + RoomNumer
                + ", check-in: "
                + CheckIn.ToString("dd/MM/yyyy")
                + ", check-out: "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + " nights ";
        }
    }
}
