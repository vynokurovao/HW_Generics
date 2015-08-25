using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Generics_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> ageMap = new MyDictionary<string, int>();
            ageMap.Add("Oksana", 21);
            ageMap.Add("Vasya", 45);
            ageMap.Add("Katya", 13);
            Console.WriteLine(String.Format("There are {0} people in data base", ageMap.Count));
            Console.WriteLine(String.Format("Oksana is {0}", ageMap["Oksana"]));
            Console.ReadKey();
        }
    }
}
