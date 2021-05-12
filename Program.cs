using System;
using SingletonTest;

namespace SingletonRest
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonLazy test1 = SingletonLazy.getInstance();
            SingletonLazy test2 = SingletonLazy.getInstance();

            SingletonLock test3 = SingletonLock.getInstance();
            SingletonLock test4 = SingletonLock.getInstance();
            Console.WriteLine("Koniec");
        }
    }
}
