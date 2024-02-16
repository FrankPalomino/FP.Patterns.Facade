
namespace FP.Patterns.Facade.Exercice3
{
    internal class TransProcSubSystem
    {
        internal void DepositFunds()
        {
            Console.WriteLine($"Deposit completed");
        }

        internal void TransferFunds()
        {
            Console.WriteLine($"Transfer completed");
        }

        internal void WithdrawFunds()
        {
            Console.WriteLine($"Withdrawing completed");
        }
    }
}
