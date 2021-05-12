using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonRest
{
    class SingletonLazy
    {
        //lazy instantiation (create if needed)
        private static readonly SingletonLazy instance = new SingletonLazy();

        private int counter = 0;

        private SingletonLazy()
        {
            Console.WriteLine("Obiekt stworzony");
        }

        public static SingletonLazy getInstance()
        {
            instance.counter++;
            Console.WriteLine("Counter = " + instance.counter);

            return instance;
        }
    }
}
