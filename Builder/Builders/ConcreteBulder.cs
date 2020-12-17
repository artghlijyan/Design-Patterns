using Builder.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Builders
{
    class ConcreteBulder : AbstractBuilder
    {
        AbstractProduct product = new Product();

        public override void BuildPartA()
        {
            product.Add(new ProductPart1());
        }

        public override void BuildPartB()
        {
            product.Add(new ProductPart2());
        }

        public override AbstractProduct GetResult()
        {
            return product;
        }
    }
}
