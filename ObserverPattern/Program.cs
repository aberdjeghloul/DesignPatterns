using System;

namespace ObserverPattern
{
    /// <summary>
    /// Observer Design Pattern. According to GoF, the Observer design Pattern should 
    /// “Define a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically” 
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            //Create a Product with Out Of Stock Status
            Subject RedMI = new Subject("RedMI Mobile", 150, "Out Of Stock");

            //User Joe will be created and user1 object will be registered to the subject
            Observer user1 = new Observer("Joe", RedMI);

            //User Bill will be created and user2 object will be registered to the subject
            Observer user2 = new Observer("Bill", RedMI);

            //User Jane will be created and user3 object will be registered to the subject
            Observer user3 = new Observer("Jane", RedMI);

            Console.WriteLine("RedMI Mobile current state : " + RedMI.getAvailability());
            Console.WriteLine();

            //Now product is available
            RedMI.setAvailability("Available");

            Console.WriteLine();
            Console.WriteLine();

            RedMI.RemoveObserver(user2);
            RedMI.setAvailability("Available");


            Console.ReadKey();
        }
    }
}
