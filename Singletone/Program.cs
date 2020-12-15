using System;
using System.Threading;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            new Thread(() =>
            {
                Thread.Sleep(1000);
                LazySingleton singleton = LazySingleton.GetInstance();
                Console.WriteLine(singleton.Version);
            }).Start();

            Thread.Sleep(1000);
            LazySingleton singleton = LazySingleton.GetInstance();
            Console.WriteLine(singleton.Version);
        }
    }
}
