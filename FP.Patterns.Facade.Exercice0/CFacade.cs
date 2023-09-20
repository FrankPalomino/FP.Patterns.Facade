using FP.Patterns.Subsystem;

namespace FP.Patterns.SybSystem
{
    internal class CFacade
    {
        private CBuySystem _buySystem = new CBuySystem();
        private CStorageSystem _storageSystem = new CStorageSystem();
        private CDeliverySystem _deliverySystem = new CDeliverySystem();

        public void Buy()
        {
            if (_buySystem.Buy() && _storageSystem.TakeFromStorage())
            {
                _deliverySystem.Deliver();
            }

        }
            
    }
}
