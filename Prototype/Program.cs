using Prototype_Pattern.Prototypes;
using System;

namespace Prototype_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Prototype clone1 = null;
            Prototype prototype1 = new ConcreteType1(1);

            clone1 = prototype1.Clone();

            Prototype clone2 = null;
            Prototype prototype2 = new ConcreteType2(2);

            clone2 = prototype2.Clone();

            Console.WriteLine(clone1);
            Console.WriteLine(clone2);
        }
    }
}
