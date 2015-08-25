using System;
using System.Collections.Generic;

namespace HW_Generics_task2
{
    class MyDictionary<TKey, TValue>
    {
        private Dictionary<TKey, TValue> _dictionary = new Dictionary<TKey, TValue>();

        public void Add(TKey key, TValue value)
        {
            _dictionary.Add(key, value);
        }

        public TValue this[TKey key]
        {
            get { return _dictionary[key]; }
        }

        public int Count
        {
            get { return _dictionary.Count; }
        }
    }
}
