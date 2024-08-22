namespace FP.Patterns.Facade.Exercice5
{
    public class HomeAutomationFacade
    {
        private readonly Light _light;
        private readonly Thermostat _thermostat;
        private readonly SecuritySystem _securitySystem;

        public HomeAutomationFacade()
        {
            _light = new Light();
            _securitySystem = new SecuritySystem();
            _thermostat = new Thermostat();
        }

        public void TurnOffAllLights()
        {
            _light.LocalizeLights();
            _light.TurnoffLight();
        }

        public void SetThermostatTemperature(int temperature)
        {
            _thermostat.Turnon();
            _thermostat.SetTemperature(temperature);
        }

        public void ActivateSecuritySystem()
        {
            _securitySystem.SetPassword("Admin123");
            _securitySystem.ActivateSystem();
        }
    }
}
