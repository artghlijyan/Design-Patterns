using Abstract_Factory.AbstractFactories.Impl;
using Abstract_Factory.Client;
using System;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientApi client1 = new ClientApi(new Factory1());
            client1.Run();

            ClientApi client2 = new ClientApi(new Factory2());
            client2.Run();
        }
    }
}
