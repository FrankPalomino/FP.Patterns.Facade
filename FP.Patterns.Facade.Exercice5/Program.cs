using FP.Patterns.Facade.Exercice5;

HomeAutomationFacade homeAutomation = new();

homeAutomation.TurnOffAllLights();
homeAutomation.SetThermostatTemperature(20);
homeAutomation.ActivateSecuritySystem();