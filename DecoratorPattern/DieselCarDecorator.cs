using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    /// <summary>
    /// This class overrides the ManufactureCar method. 
    /// What this ManufactureCar method will do is, it will add a diesel engine to the car and will return the BMW car with Diesel Engine.
    /// </summary>
    public class DieselCarDecorator : CarDecorator
    {
        public DieselCarDecorator(ICar car) : base(car)
        {
        }

        public override ICar ManufactureCar()
        {
            _car.ManufactureCar();
            AddEngine(_car);
            return _car;             
        }

        public void AddEngine(ICar car)
        {
            if(car is BMWCar)
            {
                BMWCar BMWCar = (BMWCar)car;
                BMWCar.Engine = "Diesel engine";
                Console.WriteLine("DieselCarDecorator added Diesel Engine to the Car: " + car);
            }
        }
    }
}
