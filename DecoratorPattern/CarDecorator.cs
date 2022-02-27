using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    /// <summary>
    /// Decorator class. Abstract class. ManufactureCar is declare as virtual because it has to be overriden by the child classes
    /// </summary>
    public abstract class CarDecorator
    {
        protected ICar _car;
        public CarDecorator(ICar car)
        {
            _car = car;
        }

        public virtual ICar ManufactureCar()
        {
            return _car.ManufactureCar();
        }
    }
}
