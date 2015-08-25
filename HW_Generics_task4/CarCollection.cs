using System;
using System.Collections.Generic;

namespace HW_Generics_task4
{
    class CarCollection<T> where T : ICar
    {
        private List<T> _carCollection = new List<T>();

        public void Add(T car)
        {
            _carCollection.Add(car);
        }

        public T this[int index]
        {
            get { return _carCollection[index]; }
        }

        public int Count
        {
            get { return _carCollection.Count; }
        }
    }
}
