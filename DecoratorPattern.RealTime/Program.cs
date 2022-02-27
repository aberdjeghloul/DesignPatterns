using System;

namespace DecoratorPattern.RealTime
{
    public  class Program
    {
        public static void Main(string[] args)
        {
            PizzaNature pizzaNature = new PizzaNature();
            Console.WriteLine(pizzaNature.MakePizza());

            PizzaDecorator chickenPizzaDecorator = new ChickenPizzaDecorator(pizzaNature);
            Console.WriteLine("\n" + chickenPizzaDecorator.MakePizza() + " using ChickenPizzaDecorator");

            PizzaDecorator vegPizzaDecorator = new VegPizzaDecorator(pizzaNature);
            Console.WriteLine("\n" + vegPizzaDecorator.MakePizza() + " using VegPizzaDecorator");

            Console.ReadKey();
        }
    }
}
