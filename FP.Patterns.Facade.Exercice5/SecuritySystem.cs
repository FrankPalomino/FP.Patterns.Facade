namespace FP.Patterns.Facade.Exercice5
{
    public class SecuritySystem
    {
        public void SetPassword(string password)
        {
            Console.WriteLine($"The password {password} is correct");
        }

        public void ActivateSystem()
        {
            Console.WriteLine("Security system activated");
        }
    }
}
