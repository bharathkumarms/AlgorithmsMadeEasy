using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternImplementation.SingletonImpl
{
    public sealed class Singleton
    {
        Singleton()
        {
        }
        private static readonly object padlock = new object();
        private static Singleton instance = null;
        public static Singleton Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                        Console.WriteLine("Object Created.");
                    }
                    else
                    {
                        Console.WriteLine("Created Object Created.");
                    }
                    return instance;
                }
            }
        }
    }
}
/*
    var instance = Singleton.Instance;
    var instance1 = Singleton.Instance;
    var instance2 = Singleton.Instance;

    Console.ReadLine();
*/
