using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonTest
{
    class SingletonLock
    {
        private static SingletonLock instance = null;
        private static readonly object padlock = new object();

        private int counter = 0;

        private SingletonLock()
        {
            Console.WriteLine("Obiekt stworzony");
        }

        public static SingletonLock getInstance()
        {
            lock(padlock)
            {
                if (instance == null)
                    instance = new SingletonLock();
                instance.counter++;
                Console.WriteLine("Counter = " + instance.counter);

                return instance;
            }       
        }
    }
}
