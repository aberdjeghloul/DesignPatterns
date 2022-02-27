using BuilderPattern.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.BuilderInterface
{
    public interface ICarBuilder
    {
        string Color { get; set; }
        int NumDoors { get; set; }

        Car GetResult();
    }
}
