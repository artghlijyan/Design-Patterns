using Abstract_Factory.AbstractFactories;
using Abstract_Factory.AbstractFactories.Impl;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory factory1 = new Factory1();
            factory1.Run();

            AbstractFactory factory2 = new Factory2();
            factory2.Run();
        }
    }
}
