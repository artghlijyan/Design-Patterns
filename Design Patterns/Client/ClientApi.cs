using Abstract_Factory.AbstractProducts;
using Abstract_Factory.AbstractFactories;

namespace Abstract_Factory.Client
{
    class ClientApi
    {
        AbstractProductA productA;
        AbstractProductB productb;
        AbstractFactory factory;

        public ClientApi(AbstractFactory factory)
        {
            this.factory = factory;
            this.productA = factory.CreateProductA();
            this.productb = factory.CreateProductB();
        }

        public override string ToString()
        {
            return $"{factory} use {productA} & {productb}";
        }

        public void Run()
        {
            System.Console.WriteLine(this.ToString());
        }
    }
}
