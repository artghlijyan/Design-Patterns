using Adapter.Adapters;

namespace Adapter.Provider.Impl
{
    class IpTv : IProvider
    {
        IpTvAdapter adapter;

        public IpTv()
        {
            adapter = new IpTvAdapter();
        }

        public string Use()
        {
            return adapter.Use();
        }
    }
}
