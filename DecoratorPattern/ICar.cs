using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    //Car Interface with one abstract method ManufactureCar
    public interface ICar
    {
        ICar ManufactureCar();
    }
}
