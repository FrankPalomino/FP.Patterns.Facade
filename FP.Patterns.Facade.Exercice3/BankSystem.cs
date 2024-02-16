namespace FP.Patterns.Facade.Exercice3
{
    public class BankSystem : IBankFacade
    {
        private readonly AccManagSubSystem _accountManagement;
        private readonly AuthSubSystem _authentication;
        private readonly ReportingSubSystem _reporting;
        private readonly TransProcSubSystem _transferProcess;

        public BankSystem()
        {
            _accountManagement = new AccManagSubSystem();
            _authentication = new AuthSubSystem();
            _reporting = new ReportingSubSystem();
            _transferProcess = new TransProcSubSystem();
        }

        public void AuthUser()
        {
            _authentication.ProcessUser();
        }

        public void CreateNewAccount()
        {
            _accountManagement.CreateNewAccount();
        }

        public void DepositFunds()
        {
            _transferProcess.DepositFunds();
        }

        public void GeneratingAccountStatements()
        {
            _reporting.GenerateStatements();
        }

        public void TransferringFunds()
        {
            _transferProcess.TransferFunds();
        }

        public void WithdrawFunds()
        {
            _transferProcess.WithdrawFunds();
        }
    }
}
