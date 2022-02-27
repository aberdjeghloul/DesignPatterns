using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public interface IProduct
    {
        string GetName();
        string SetPrice(double price);
        double GetPrice();
    }
}
