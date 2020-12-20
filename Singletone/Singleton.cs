using System;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton
{
    sealed class Singleton
    {
        private static Singleton singleton;
        //private static readonly Singleton singleton = new Singleton();

        public int Version { get; private set; }

        private static object _lock = new Object();

        private Singleton()
        {
            Version = (new Random()).Next(100);
        }

        public static Singleton GetInstance()
        {
            lock (_lock)
            {
                return SetInstance();
            }
        }

        private static Singleton SetInstance()
        {
            if (singleton is null)
                singleton = new Singleton();

            return singleton;
        }

        public static async Task<Singleton> GetInstanceAsync()
        {
            await Task.Run(SetInstance);
            return singleton;
        }

        public override string ToString()
        {
            return $"Singleton version: {this.Version}";
        }
    }
}
