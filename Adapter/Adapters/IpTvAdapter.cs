using Adapter.Adaptees;
using Adapter.Provider;

namespace Adapter.Adapters
{
    class IpTvAdapter : IProvider
    {
        Tv tv = new Tv();

        public string Use()
        {
            return tv.Watch() + " With IpTv";
        }
    }
}
