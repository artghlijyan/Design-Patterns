namespace Abstract_Factory.AbstractFactories
{
    abstract class AbstractFactory
    {
        public abstract string Description { get; set; }

        public abstract AbstractProducts.AbstractProductA CreateProductA();

        public abstract AbstractProducts.AbstractProductB CreateProductB();
        
    }
}
