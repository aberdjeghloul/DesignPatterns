using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.RealTime
{
    public class ChickenPizzaDecorator : PizzaDecorator
    {
        public ChickenPizzaDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string MakePizza()
        {
            return _pizza.MakePizza() + AddChicken();
        }

        private string AddChicken()
        {
            return " , Chicken added";
        }
    }
}
