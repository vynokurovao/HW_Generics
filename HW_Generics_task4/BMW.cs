using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Generics_task4
{
    class BMW : ICar
    {
        private string _name;
        private int _year;

        public BMW(string name, int year)
        {
            _name = name;
            _year = year;
        }
    }
}
