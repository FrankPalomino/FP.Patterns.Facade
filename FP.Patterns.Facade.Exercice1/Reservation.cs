namespace FP.Patterns.Facade.Exercice1
{
    public class Reservation
    {
        public int ReservationNumber { get; set; }
        public Room ReservedRoom { get; set; }
        public DateTime Enter { get; set; }
        public DateTime Leave { get; set; }
        public string ClientName { get; set; }
    }
}
