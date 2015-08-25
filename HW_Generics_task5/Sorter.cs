using System;
using System.Collections.Generic;

namespace HW_Generics_task5
{
    public class Sorter
    {
        public static void Sort<TCollection, TType>(TCollection collection) where TType : IComparable where TCollection : IList<TType>
        {
            for (int i = 0; i < collection.Count - 1; i++)
            {
                for (int j = 0; j < collection.Count - i - 1; j++)
                {
                    if (collection[j].CompareTo(collection[j + 1]) > 0)
                    { 
                        TType tmp = collection[j];
                        collection[j] = collection[j + 1];
                        collection[j + 1] = tmp;
                    }
                }
            }
        }
    }
}
