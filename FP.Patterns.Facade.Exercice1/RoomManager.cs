namespace FP.Patterns.Facade.Exercice1
{
    public class RoomManager
    {
        private List<Room> _rooms;

        public RoomManager()
        {
            _rooms = new List<Room>()
            {
                new Room() { RoomNumber = 1, PricePerNight = 100 }, 
                new Room() { RoomNumber = 2, PricePerNight = 200 } 
            };
        }

        public bool CheckAvailability(DateTime enter, DateTime leave)
        {
            return _rooms.Count > 0;
        }
    }
}
