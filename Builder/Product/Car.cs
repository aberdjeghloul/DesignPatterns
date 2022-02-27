using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.Product
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int NumDoors { get; set; }
        public string Color { get; set; }

        public Car(string make, string model, int numDoors, string color)
        {
            Make = make;
            Model = model;
            NumDoors = numDoors;
            Color = color;
        }
    }
}
