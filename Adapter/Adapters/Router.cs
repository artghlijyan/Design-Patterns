using Adapter.Adaptees;
using Adapter.Provider;

namespace Adapter.Adapters
{
    class Router : IProvider
    {
        Computer computer = new Computer();

        public string Use()
        {
            return computer.Use() + " to browse Internet";
        }
    }
}
