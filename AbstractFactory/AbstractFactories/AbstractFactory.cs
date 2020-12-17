using Abstract_Factory.AbstractProducts;

namespace Abstract_Factory.AbstractFactories
{
    abstract class AbstractFactory
    {
        AbstractProductA productA;
        AbstractProductB productb;

        public abstract string Description { get; set; }

        protected abstract AbstractProductA CreateProductA();

        protected abstract AbstractProductB CreateProductB();

        public void Run()
        {
            this.productA = CreateProductA();
            this.productb = CreateProductB();
            System.Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            return $"{Description} use {productA.Description} & {productb.Description}";
        }
    }
}
