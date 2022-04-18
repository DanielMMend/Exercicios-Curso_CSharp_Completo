using System;
using S11_Exercicio_Excecoes_1.Entities.Exceptions;

namespace S11_Exercicio_Excecoes_1.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkIn >= checkOut)
            {
                throw new DomainExecption("Check-out date must be after check-in date.");
            }
            else if (checkIn < DateTime.Now || checkOut < DateTime.Now)
            {
                throw new DomainExecption("Reservation dates must be future dates.");
            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }
        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            if (checkIn >= checkOut)
            {
                throw new DomainExecption("Check-out date must be after check-in date.");
            }
            else if (checkIn < DateTime.Now || checkOut < DateTime.Now)
            {
                throw new DomainExecption("Reservation dates for update must be future dates.");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return 
                $"Reservation: Room {RoomNumber}," +
                $" check-in: {CheckIn.ToString("dd/MM/yyyy")}," +
                $" check-out: {CheckOut.ToString("dd/MM/yyyy")}," +
                $" {Duration()} night(s)";
        }
    }
}
