using System;
using System.Collections.Generic;

namespace HW_Generics_task1
{
    public class MyList<T>
    {
        private List<T> _list = new List<T>();

        public int Count
        {
            get {return _list.Count;}
        }

        public T this[int index]
        {
            get { return _list[index]; }
        }

        public void Add(T element)
        {
            _list.Add(element);
        }
    }
}
