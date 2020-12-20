using System;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton = null;

            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(100);
                new Thread(() =>
                {
                    if (singleton is null)
                    {
                        singleton = Singleton.GetInstanceAsync().Result;
                        Console.WriteLine("Singletone Version: " + singleton.Version);
                    }
                    else
                    {
                        Console.WriteLine("Singletone already Set");
                    }

                }).Start();
            }
        }
    }
}
