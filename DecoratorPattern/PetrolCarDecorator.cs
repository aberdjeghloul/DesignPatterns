using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class PetrolCarDecorator : CarDecorator
    {
        public PetrolCarDecorator(ICar car) : base(car)
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
            if (car is BMWCar)
            {
                BMWCar BMWCar = (BMWCar)car;
                BMWCar.Engine = "Petrol Engine";
                Console.WriteLine("PetrolCarDecorator added Petrol Engine to the Car: " + _car);
            }
        }
    }
}
