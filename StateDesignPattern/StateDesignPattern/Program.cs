using System;

namespace StateDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            StateContext vendingMachine = new StateContext();
            Console.WriteLine("Current VendingMachine State : "
                            + vendingMachine._currentState.GetType().Name + "\n");
            vendingMachine.DispenseProduct();
            vendingMachine.SelectProductAndInsertMoney(50, "Pepsi");
            // Money has been inserted so vending Machine internal state
            // changed to 'hasMoneyState'
            Console.WriteLine("\nCurrent VendingMachine State : "
                            + vendingMachine._currentState.GetType().Name + "\n");
            vendingMachine.SelectProductAndInsertMoney(50, "Fanta");
            vendingMachine.DispenseProduct();
            // Product has been dispensed so vending Machine internal state
            // changed to 'NoMoneyState'
            Console.WriteLine("\nCurrent VendingMachine State : "
                            + vendingMachine._currentState.GetType().Name);

            Console.ReadLine();
        }
    }
}
