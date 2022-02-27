using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.ConcreteProducts
{
    public class Phone : IProduct
    {
        private double _price;
        public string GetName()
        {
            return "HUAWEI";
        }

        public string SetPrice(double price)
        {
            this._price = price;
            return "success";
        }

        public double GetPrice()
        {
            return _price;
        }
    }
}
