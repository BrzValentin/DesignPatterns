namespace Facade
{
    public class TransactionControllerFacade
    {
        private readonly BankController _bankController;
        private readonly ClientController _clientController;

        public TransactionControllerFacade(BankController bankController, ClientController clientController)
        {
            _bankController = bankController;
            _clientController = clientController;
        }

        public void TransferMoney(double amount)
        {
            _clientController.OpenTransaction();
            _bankController.OpenTransaction();
            
            _clientController.TransferMoney(amount);
            _bankController.TransferMoney(amount);
            
            _clientController.CloseTransaction();
            _bankController.CloseTransaction();
        }
    }
}