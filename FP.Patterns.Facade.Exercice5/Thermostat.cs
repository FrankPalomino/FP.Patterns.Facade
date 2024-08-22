namespace FP.Patterns.Facade.Exercice5
{
    public class Thermostat
    {
        public void Turnon()
        {
            Console.WriteLine("The thermostat is On");
        }

        public void SetTemperature(int temperature)
        {
            Console.WriteLine($"The termostat is setted on {temperature}ºC");
        }
    }
}
