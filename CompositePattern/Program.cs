using CompositePattern.Composite;
using CompositePattern.Leaves;
using System;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Latte latte = new Latte(350);
            latte.Flavors.Add(new CinamonLatte(400));
            latte.Flavors.Add(new VanillaLatte(300));

            Expresso expresso = new Expresso(10);

            Cappuccino cappuccino = new Cappuccino(450);
            cappuccino.Flavors.Add(new CaramelCappuccino(500));
            cappuccino.Flavors.Add(new PeppermintCappuccino(425));

            HotCoffee hotCoffee = new HotCoffee(100);
            hotCoffee.Flavors.Add(latte);
            hotCoffee.Flavors.Add(expresso);
            hotCoffee.Flavors.Add(cappuccino);

            hotCoffee.DisplayCalories();
            Console.ReadKey();
        }
    }
}
