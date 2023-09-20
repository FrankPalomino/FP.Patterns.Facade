namespace FP.Patterns.Facade.Exercice1
{
    public class HotelFacade
    {
        private RoomManager _roomManager;
        private ReservationManager _reservationManager;

        public HotelFacade()
        {
            _roomManager = new RoomManager();
            _reservationManager = new ReservationManager();
        }

        public bool CheckAvailability(DateTime enter, DateTime leave)
        {
            return _roomManager.CheckAvailability(enter, leave);
        }

        public bool MakeReservation(Room room, DateTime enter, DateTime leave, string client)
        {
            if(CheckAvailability(enter, leave))
            {
                Reservation reservation = _reservationManager.MakeReservation(room, enter, leave, client);
                _reservationManager.GetConfirmation(reservation);
                return true;
            }
            else
            {
                Console.WriteLine("No rooms available");
                return false;
            }
        }

        public bool CancelReservation(Reservation reservationCode)
        {
            return _reservationManager.CancelReservation(reservationCode);
        }

        public void GetReservationConfirmation(Reservation reservationCode)
        {
            _reservationManager.GetConfirmation(reservationCode);
        }
    }
}
