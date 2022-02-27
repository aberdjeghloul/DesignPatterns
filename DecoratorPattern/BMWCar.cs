using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    /// <summary>
    /// Concrete class. Implements ICar interface  i.e. provides an implementation for the ManufactureCar method. 
    /// What this ManufactureCar method will do is, it will manufacture Car Body, Door, Wheels, and Glass. 
    /// So, when we call this ManufactureCar method it returns the BMW car without an engine.
    /// </summary>
    public class BMWCar : ICar
    {
        public const string CarName = "BMW";
        public string CarBody { get; private set; }
        public string CarDoor { get; private set; }
        public string CarWheels { get; private set; }
        public string CarGlass { get; private set; }
        public string Engine { get; set; }

        public ICar ManufactureCar()
        {
            CarBody = "carbon fiber material";
            CarDoor = "4 car doors";
            CarWheels = "4 MRF wheels";
            CarGlass = "6 car glasses";
            return this;
        }

        public override string ToString()
        {
            return $"BMWCar [CarName={CarName}, CarBody={CarBody}, CarDoor={CarDoor}, CarGlass={CarGlass}, Engine={Engine}]";
        }
    }
}
