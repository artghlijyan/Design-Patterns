using Abstract_Factory.AbstractProducts;
using Abstract_Factory.AbstractProducts.Impl;

namespace Abstract_Factory.AbstractFactories.Impl
{
    class Factory1 : AbstractFactory
    {
        public override string Description { get; set; } = "Factory1";

        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }

        public override string ToString()
        {
            return this.Description;
        }
    }
}
