using System;
using System.Collections;
using tutorial.GenericDataStore;

namespace tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat(1);

            const int ConstantMax = int.MaxValue;
            int int1;
            int int2;
            int variableMax = 2147483647;

            int1 = unchecked(2147483647 + 10);

            //Array foreach
            int[] a = { 3, 5, 6, 7 };
            Array.ForEach(a, n => Console.WriteLine(n));

            var customIndexer = new DemoStorage();
            customIndexer[3] = "10";

            //Generic
            DataStore<DemoStorage> dataStore = new DataStore<DemoStorage>();
            dataStore.Data = customIndexer;
            Console.WriteLine(dataStore.Data[3]);

            //Tuple
            var testTuple = Tuple.Create("1", "Quân", "Hello", 1);
            Console.WriteLine(testTuple.Item1);

            //Deligate
            DeligateMethods deligateMethods = new DeligateMethods();
            Console.ReadKey();
            Console.WriteLine();
        }
    }
}
