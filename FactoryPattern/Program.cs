using FactoryPattern.Factory;
using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductFactory phoneFactory = new PhoneFactory();
            IProduct phone = phoneFactory.GetProduct();
            Console.WriteLine($"{phone.GetType().Name}: {phone.GetName()} price: {phone.GetPrice()}");

            ProductFactory tabletFactory = new TabletFactory();
            IProduct tablet = tabletFactory.GetProduct();
            Console.WriteLine($"{tablet.GetType().Name}: {tablet.GetName()} price: {tablet.GetPrice()}");

            Console.ReadKey();
        }
    }
}
