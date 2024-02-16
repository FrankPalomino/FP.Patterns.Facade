namespace FP.Patterns.Facade.Exercice3
{
    public interface IBankFacade
    {
        void CreateNewAccount();
        void DepositFunds();
        void WithdrawFunds();
        void TransferringFunds();
        void GeneratingAccountStatements();
        void AuthUser();
    }
}
