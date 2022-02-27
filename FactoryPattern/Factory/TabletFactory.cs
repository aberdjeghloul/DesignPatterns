using FactoryPattern.ConcreteProducts;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Factory
{
    public class TabletFactory : ProductFactory
    {
        protected override IProduct CreateProduct()
        {
            IProduct tablet = new Tablet();
            tablet.SetPrice(699.99);
            return tablet;
        }
    }
}
