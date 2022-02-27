using System;

namespace DecoratorPattern
{
    /// <summary>
    /// The Decorator Design Pattern provides an alternative approach to inheritance for modifying the behavior of an object. 
    /// When we use inheritance to extend the behavior of a class, then this takes place at compile time.
    /// Let us understand the decorator design pattern with one real-time example. 
    /// Suppose whe have a car without any engine. 
    /// Let say, I want to add either the Petrol engine or Diesel engine to this car. 
    /// Then what I need to do is, I have to introduce the Car Decorator. 
    /// What this Car Decorator will do is, it will add an Engine to the Car. 
    /// Let say I want to add a Petrol Engine then the Car Decorator will add the Petrol Engine to this car and return the car with a petrol engine. 
    /// Suppose, I want to add a Diesel Engine to this car, then the Car Decorator will add a Diesel engine to this car and return the car with the Diesel engine.
    /// As per the Decorator Design Pattern, the work of the decorator is to add new functionalities or behavior to an existing object without altering its structure. 
    /// So, in this case, Car without an engine is the existing object. 
    /// What the Car Decorator does is, it will add a Petrol Engine or a Diesel Engine to the Car based on the requirement. 
    /// So, I think this is one of the best real-time examples of the Decorator Design Pattern.
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            //Create an instance of BMWCar and call its ManufactureCar method which will create a car without engine
            ICar bMWCar1 = new BMWCar();
            bMWCar1.ManufactureCar();
            Console.WriteLine(bMWCar1 + "\n");

            //Then create the instance of DieselCarDecorator and pass the BMWCar instance as a parameter to the Constructor
            //And when we call the ManufactureCar method of the DieselCarDecorator instance, then it will add Diesel Engine to the Car
            DieselCarDecorator carWithDieselEngine = new DieselCarDecorator(bMWCar1);
            carWithDieselEngine.ManufactureCar();

            Console.WriteLine();

            ICar bMWCar2 = new BMWCar();
            PetrolCarDecorator carWithPetrolEngine = new PetrolCarDecorator(bMWCar2);
            carWithPetrolEngine.ManufactureCar();

            Console.ReadKey();

        }
    }
}
