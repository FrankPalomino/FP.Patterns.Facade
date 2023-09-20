namespace FP.Patterns.Subsystem
{
    public class CBuySystem
    {
        public bool Buy()
        {
            string data = "";
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter your card number:");
            data = Console.ReadLine();

            if(data == "12345")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Payment successful!");
                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Payment failed!");
                return false;
            }
        }
    }

    public class  CStorageSystem
    {
        private int _count;

        public CStorageSystem()
        {
            _count = 3;
        }

        public bool TakeFromStorage()
        {
            if(_count > 0)
            {
                _count--;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Product taken from storage!");
                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Product is out of stock!");
                return false;
            }
        }
    }

    public class CDeliverySystem
    {
        public void Deliver()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Product delivered!");
        }
    }
}
