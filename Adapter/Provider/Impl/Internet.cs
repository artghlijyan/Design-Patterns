using Adapter.Adapters;

namespace Adapter.Provider.Impl
{
    class Internet : IProvider
    {
        Router internet;

        public Internet()
        {
            internet = new Router();
        }

        public string Use()
        {
            return internet.Use();
        }
    }
}
