using Adapter.Adaptees;
using Adapter.Clients;
using Adapter.Provider.Impl;

namespace Adapter // Adapt incompatable interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            
            client.UseTv(new Tv());
            client.UseComputer(new Computer());
            client.Use(new IpTv());
            client.Use(new Internet());
        }
    }
}
