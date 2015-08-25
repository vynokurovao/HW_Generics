using System;
using System.Collections.Generic;
using HW_Generics_task1;

namespace HW_Generics_task3
{
    public static class Extension
    {
        public static List<T> GetArray<T>(this MyList<T> list)
        {
            List<T> newList = new List<T>();
            for (int i = 0; i < list.Count; i++)
            {
                newList.Add(list[i]);
            }
            return newList;
        }
    }
}
