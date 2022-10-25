using System;
using System.Collections.Generic;
using System.Text;

namespace StateDesignPattern
{
    public class NoMoneyState : IVendingMachineState
    {
        public void DispenseProduct()
        {
            Console.WriteLine("Vending Machine cannot dispense product because money is not inserted and product is not selected");
        }

        public void SelectProductAndInsertMoney(int amount, string productName)
        {
            Console.WriteLine(amount + " "+ "has been inserted and " + productName + " "+ "is selected");
        }
    }
}
