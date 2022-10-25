using System;
using System.Collections.Generic;
using System.Text;

namespace StateDesignPattern
{
    public class HasMoneyState : IVendingMachineState
    {
        public void DispenseProduct()
        {
            Console.WriteLine("Product is dispensed");
        }

        public void SelectProductAndInsertMoney(int amount, string productName)
        {
            Console.WriteLine("Vending machine cannot process the request because it is in progress");
        }
    }
}
