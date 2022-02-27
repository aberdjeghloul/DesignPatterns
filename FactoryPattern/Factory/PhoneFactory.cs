using FactoryPattern.ConcreteProducts;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Factory
{
    public class PhoneFactory : ProductFactory
    {
        protected override IProduct CreateProduct()
        {
            IProduct phone = new Phone();
            phone.SetPrice(199.99);
            return phone;
        }
    }
}
