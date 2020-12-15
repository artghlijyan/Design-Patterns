using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Products
{
    abstract class Product
    {
        public abstract string Description { get; set; }

        public override string ToString()
        {
            return Description;
        }
    }
}
