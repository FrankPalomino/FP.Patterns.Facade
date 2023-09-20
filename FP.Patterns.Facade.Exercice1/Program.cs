using FP.Patterns.Facade.Exercice1;

HotelFacade facade = new HotelFacade();

if(facade.CheckAvailability(DateTime.Now, DateTime.Now.AddDays(1)))
{
    facade.MakeReservation(new Room() { RoomNumber = 1}, DateTime.Now, DateTime.Now.AddDays(1), "John Doe");
}
else
{
    Console.WriteLine("No rooms available");
}