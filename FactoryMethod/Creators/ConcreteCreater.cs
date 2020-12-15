using FactoryMethod.Products;

namespace FactoryMethod.Creators
{
    class ConcreteCreater : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProduct();
        }
    }
}
