using FactoryMethod.Creators;
using FactoryMethod.Products;
using System;

namespace FactoryMethod // base for all 4 Generative patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator creator = new ConcreteCreater();
            Product product = creator.FactoryMethod();

            Console.WriteLine(product);
        }
    }
}
