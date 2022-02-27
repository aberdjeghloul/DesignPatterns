using BuilderPattern.BuilderInterface;
using BuilderPattern.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.ConcreteBuilder
{
    public class HondaBuilder : ICarBuilder
    {
        public string Color { get; set; }
        public int NumDoors { get; set; }

        public Car GetResult()
        {
            return NumDoors == 2 ? new Car("Honda", "Civic", NumDoors, Color) : null;
        }
    }
}
