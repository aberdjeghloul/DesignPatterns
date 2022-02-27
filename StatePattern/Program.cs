using System;

namespace StatePattern
{
    /// <summary>
    /// State Design Pattern. According to Gang of Four Definitions, the State Design Pattern allows an object to alter its behavior when its internal state changes. 
    /// In simple words, we can say that the State Pattern is a design pattern that allows an object to completely change its behavior depending upon its current internal state.
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            // Initially ATM Machine in DebitCardNotInsertedState
            ATMMachine atmMachine = new ATMMachine();
            Console.WriteLine("ATM Machine Current state : "
                            + atmMachine.ATMMachineState.GetType().Name);
            Console.WriteLine();
            atmMachine.EnterPin();
            atmMachine.WithdrawMoney();
            atmMachine.EjectDebitCard();
            atmMachine.InsertDebitCard();
            Console.WriteLine();
            // Debit Card has been inserted so internal state of ATM Machine
            // has been changed to DebitCardInsertedState
            Console.WriteLine("ATM Machine Current state : "
                            + atmMachine.ATMMachineState.GetType().Name);
            Console.WriteLine();
            atmMachine.EnterPin();
            atmMachine.WithdrawMoney();
            atmMachine.InsertDebitCard();
            atmMachine.EjectDebitCard();
            Console.WriteLine("");
            // Debit Card has been ejected so internal state of ATM Machine
            // has been changed to DebitCardNotInsertedState
            Console.WriteLine("ATM Machine Current state : "
                            + atmMachine.ATMMachineState.GetType().Name);

            Console.ReadKey();
        }
    }
}
