using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Factory
{
    public abstract class ProductFactory
    {
        protected abstract IProduct CreateProduct();
        
        public IProduct GetProduct()
        {
            return this.CreateProduct();
        }
    }
}
