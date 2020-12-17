using Abstract_Factory.AbstractProducts;
using Abstract_Factory.AbstractProducts.Impl;

namespace Abstract_Factory.AbstractFactories.Impl
{
    class Factory1 : AbstractFactory
    {
        public override string Description { get; set; } = "Factory1";

        protected override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        protected override AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }
}
