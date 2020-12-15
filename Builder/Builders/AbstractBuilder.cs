using Builder.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Builders
{
    abstract class AbstractBuilder
    {
        public abstract void BuildPartA();
        public abstract void BuildPartB();

        public abstract Product GetResult();
    }
}
