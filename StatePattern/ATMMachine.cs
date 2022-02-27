using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    /// <summary>
    /// Concrete class. 
    /// </summary>
    public class ATMMachine : IATMState
    {
        public IATMState ATMMachineState { get; set; }

        public ATMMachine()
        {
            ATMMachineState = new DebitCardNotInsertedState();
        }

        public void InsertDebitCard()
        {
            ATMMachineState.InsertDebitCard();

            // Debit Card has been inserted so internal state of ATM Machine
            // has been changed to 'DebitCardInsertedState'
            if(ATMMachineState is DebitCardNotInsertedState)
            {
                ATMMachineState = new DebitCardInsertedState();
                Console.WriteLine("ATM Machine internal state has been moved to : " + ATMMachineState.GetType().Name);
            }
        }

        public void EjectDebitCard()
        {
            ATMMachineState.EjectDebitCard();

            // Debit Card has been ejected so internal state of ATM Machine
            // has been changed to 'DebitCardNotInsertedState'
            if (ATMMachineState is DebitCardInsertedState)
            {
                ATMMachineState = new DebitCardNotInsertedState();
                Console.WriteLine("ATM Machine internal state has been moved to " + ATMMachineState.GetType().Name);
            }

        }

        public void EnterPin()
        {
            ATMMachineState.EnterPin();
        }

        public void WithdrawMoney()
        {
            ATMMachineState.WithdrawMoney();
        }
    }
}
