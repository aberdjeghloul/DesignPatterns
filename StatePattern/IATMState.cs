using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    /// <summary>
    /// The ATMState interface defines the common methods for all the concrete states. 
    /// All the concrete states will implement this interface so that they are going to be interchangeable. 
    /// Here, we created the interface with the required four operations.
    /// </summary>
    public interface IATMState
    {
        void InsertDebitCard();
        void EjectDebitCard();
        void EnterPin();
        void WithdrawMoney();
    }
}
