using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Generics_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> stringList = new MyList<string>();
            stringList.Add("Hello");
            stringList.Add("world");
            Console.WriteLine(stringList.Count);
            stringList.Add("Oksana");
            Console.WriteLine(String.Format("{0} {1}", stringList[0], stringList[1]));
            Console.ReadKey();
        }
    }
}
