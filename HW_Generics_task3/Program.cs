using System;
using System.Collections.Generic;
using HW_Generics_task1;

namespace HW_Generics_task3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<String> list = new MyList<String>();
            list.Add("Hello");
            list.Add("world");
            List<string> extractedList = list.GetArray<string>();

            for (int i = 0; i < extractedList.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadKey();
        }
    }
}
