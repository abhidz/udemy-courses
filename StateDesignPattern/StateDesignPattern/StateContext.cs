using System;
using System.Collections.Generic;
using System.Text;

namespace StateDesignPattern
{
    public class StateContext : IVendingMachineState
    {
        public IVendingMachineState _currentState { get; set; }
        public StateContext()
        {
            _currentState = new NoMoneyState();
        }
        public void DispenseProduct()
        {
            // Product has been dispensed so vending Machine changed the
            // internal state to 'NoMoneyState'
            _currentState.DispenseProduct();

            if (_currentState is HasMoneyState)
            {
                _currentState = new NoMoneyState();
                Console.WriteLine("VendingMachine internal state has been moved to : " + _currentState.GetType().Name);
            }
        }

        public void SelectProductAndInsertMoney(int amount, string productName)
        {
            // Money has been inserted so vending Machine internal state 
            // changed to 'hasMoneyState'
            _currentState.SelectProductAndInsertMoney(amount, productName);

            if (_currentState is NoMoneyState)
            {
                _currentState = new HasMoneyState();
                Console.WriteLine("VendingMachine internal state has been moved to : " + _currentState.GetType().Name);
            }
        }
    }
}
