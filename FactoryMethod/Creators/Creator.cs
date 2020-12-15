using FactoryMethod.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Creators
{
    abstract class Creator
    {
        Product product;

        public abstract Product FactoryMethod();
    }
}
