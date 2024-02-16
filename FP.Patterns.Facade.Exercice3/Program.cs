using FP.Patterns.Facade.Exercice3;

BankSystem bankSystem = new BankSystem();

bankSystem.CreateNewAccount();
bankSystem.AuthUser();
bankSystem.DepositFunds();
bankSystem.TransferringFunds();
bankSystem.WithdrawFunds();
bankSystem.GeneratingAccountStatements();