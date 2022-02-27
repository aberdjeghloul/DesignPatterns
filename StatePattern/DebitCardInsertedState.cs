using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    /// <summary>
    /// Concrete class according to one of the two states of the ATM. Behavior when debit card is inserted in ATM slot
    /// </summary>
    public class DebitCardInsertedState : IATMState
    {
        public void EjectDebitCard()
        {
            Console.WriteLine("Debit Card is ejected");
        }

        public void EnterPin()
        {
            Console.WriteLine("Pin number has been entered correctly");
        }

        public void InsertDebitCard()
        {
            Console.WriteLine("You cannot insert the Debit Card, as the Debit Card is already there");
        }

        public void WithdrawMoney()
        {
            Console.WriteLine("Money has been withdrawn");
        }
    }
}
