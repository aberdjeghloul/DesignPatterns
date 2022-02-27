using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.RealTime
{
    public class VegPizzaDecorator : PizzaDecorator
    {
        public VegPizzaDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string MakePizza()
        {
            return _pizza.MakePizza() + AddVegetable();
        }

        private string AddVegetable()
        {
            return ", Vegetables added";
        }
    }
}
