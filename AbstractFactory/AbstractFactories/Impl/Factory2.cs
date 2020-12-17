using Abstract_Factory.AbstractProducts;
using Abstract_Factory.AbstractProducts.Impl;

namespace Abstract_Factory.AbstractFactories.Impl
{
    class Factory2 : AbstractFactory
    {
        public override string Description { get; set; } = "Factory2";

        protected override AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }

        protected override AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }
}