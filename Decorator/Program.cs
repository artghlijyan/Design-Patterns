using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Coffee coffee = new Coffee();
            Bevarage cappuccino = new CappuccinoDecorator(coffee);

            Console.WriteLine(cappuccino);
        }
    }
}
