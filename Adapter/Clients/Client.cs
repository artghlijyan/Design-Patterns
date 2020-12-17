using Adapter.Adaptees;
using Adapter.Provider;
using System;
namespace Adapter.Clients
{
    class Client
    {

        public void Use(IProvider provider)
        {
            Console.WriteLine(provider.Use());
        }

        // old version
        public void UseTv(Tv tv)
        {
            Console.WriteLine(tv.Watch());
        }

        // old version
        public void UseComputer(Computer computer)
        {
            Console.WriteLine(computer.Use());
        }
    }
}
