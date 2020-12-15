using System;

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
            Version = (new Random()).Next(10);
        }

        public static Singleton GetInstance()
        {
            lock (_lock)
            {
                if (singleton is null)
                    singleton = new Singleton();

                return singleton; 
            }
        }

        public override string ToString()
        {
            return $"Singleton version: {this.Version}";
        }
    }
}
