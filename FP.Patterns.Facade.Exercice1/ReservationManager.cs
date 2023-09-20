namespace FP.Patterns.Facade.Exercice1
{
    public class ReservationManager
    {
        private List<Reservation> _reservations;
        private int nextReservationNumber = 1;

        public ReservationManager()
        {
            _reservations = new List<Reservation>();
        }

        public Reservation MakeReservation(Room room, DateTime enter, DateTime leave, string client)
        {
            Reservation reservation = new Reservation()
            {
                ReservationNumber = nextReservationNumber++,
                ReservedRoom = room,
                Enter = enter,
                Leave = leave,
                ClientName = client
            };

            _reservations.Add(reservation);

            return reservation;
        }

        public bool CancelReservation(Reservation reservationCode)
        {
            return _reservations.Remove(reservationCode);
        }

        public void GetConfirmation(Reservation reservationCode)
        {
            Console.WriteLine("Reservation confirmed");
            Console.WriteLine("Reservation number: " + reservationCode.ReservationNumber);
            Console.WriteLine("Room number: " + reservationCode.ReservedRoom.RoomNumber);
            Console.WriteLine("Price per night: " + reservationCode.ReservedRoom.PricePerNight);
            Console.WriteLine("Enter: " + reservationCode.Enter);
            Console.WriteLine("Leave: " + reservationCode.Leave);
            Console.WriteLine("Client: " + reservationCode.ClientName);
        }
    }
}
