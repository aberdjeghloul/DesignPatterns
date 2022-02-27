using BuilderPattern.ConcreteBuilder;
using BuilderPattern.Director;
using BuilderPattern.Product;
using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            HondaBuilder builder = new HondaBuilder();
            CarBuildDirector director = new CarBuildDirector(builder);

            director.Construct();
            Car myHonda = builder.GetResult();

            Console.WriteLine($"{myHonda.Make} {myHonda.Model} {myHonda.NumDoors} {myHonda.Color}");

            Console.ReadKey();
        }
    }
}
