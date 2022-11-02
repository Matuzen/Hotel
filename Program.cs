using System;
using Hotel.Entities;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Room number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkin = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime checkout = DateTime.Parse(Console.ReadLine());

            if (checkout <= checkin)
            {
                Console.WriteLine("Erro in reservation: check-out date be after check-in date");
            }

            else
            {
                Reservation reservation = new Reservation(number, checkin, checkout);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation:");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkout = DateTime.Parse(Console.ReadLine());

                // Datas de atualização devem ser posteriores a data atual
                DateTime now = DateTime.Now; // Pega a data com um instante atual
                if (checkin < now || checkout < now)
                {
                    Console.WriteLine("Error in reservation: Reservation dates for update must be future dates");
                }

                // Falata testar a data de saída se é maior que a data de entrada
                else if (checkout <= checkin)
                {
                    Console.WriteLine("Erro in reservation: check-out date be after check-in date");
                }

                else
                {
                    reservation.UpdateDates(checkin, checkout);
                    Console.WriteLine("Reservation: " + reservation);
                }
            }
        }
    }
}
