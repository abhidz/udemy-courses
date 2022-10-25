using System;
using System.Collections.Generic;
using System.Text;

namespace StateDesignPattern
{
    public interface IVendingMachineState
    {
        void SelectProductAndInsertMoney(int amount, string productName);
        void DispenseProduct();
    }
}
