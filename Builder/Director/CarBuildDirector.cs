using BuilderPattern.BuilderInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.Director
{
    public class CarBuildDirector
    {
        private ICarBuilder _carBuilder;

        public CarBuildDirector(ICarBuilder carBuilder)
        {
            _carBuilder = carBuilder;
        }

        public void Construct()
        {
            _carBuilder.Color = "Red";
            _carBuilder.NumDoors = 2;
        }
    }
}
