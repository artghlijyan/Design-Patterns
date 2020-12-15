using System;

namespace Singleton
{
    // in case object has several static fields or methods
    // no need to instantiate singletone object
    // when other static member is called

    class LazySingleton
    {
        public int Version { get; private set; }

        private LazySingleton()
        {
            Version = (new Random()).Next(10);
        }

        public static LazySingleton GetInstance()
        {
            return Nested.instance;
        }

        private class Nested
        {
            internal static readonly LazySingleton instance;

            static Nested()
            {
                instance = new LazySingleton();
            }
        }

    }
}
