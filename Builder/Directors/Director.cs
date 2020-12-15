using Builder.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Directors
{
    class Director
    {
        public void Construct(AbstractBuilder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }
}
