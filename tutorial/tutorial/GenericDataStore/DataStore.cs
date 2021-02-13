using System;
using System.Collections.Generic;
using System.Text;

namespace tutorial.GenericDataStore
{
    class DataStore<T> where T : DemoStorage
    {
        public T Data { get; set; }
    }

    class KeyValuePair<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
    }

}
