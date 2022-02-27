using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.RealTime
{
    public class PizzaNature : IPizza
    {
        public string MakePizza()
        {
            return "Pizza Nature";
        }
    }
}
