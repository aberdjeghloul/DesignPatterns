using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.RealTime
{
    public abstract class PizzaDecorator : IPizza
    {
        protected IPizza _pizza;

        public PizzaDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }

        public virtual string MakePizza()
        {
            return _pizza.MakePizza();
        }
    }
}
