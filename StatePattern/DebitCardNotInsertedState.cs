using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    /// <summary>
    /// Concrete class according to one of the two states of the ATM. Behavior when debit card is NOT inserted in ATM slot
    /// </summary>
    public class DebitCardNotInsertedState : IATMState
    {
        public void EjectDebitCard()
        {
            Console.WriteLine("You cannot eject the Debit card, as no Debit Card in ATM Machine slot");
        }

        public void EnterPin()
        {
            Console.WriteLine("You cannot enter the pin, as no Debit Card in ATM Machine slot");
        }

        public void InsertDebitCard()
        {
            Console.WriteLine("DebitCard Inserted");
        }

        public void WithdrawMoney()
        {
            Console.WriteLine("You cannot withdraw money, as no Debit Card in ATM Machine slot");
        }
    }
}
