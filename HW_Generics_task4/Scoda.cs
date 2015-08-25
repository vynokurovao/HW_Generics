using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Generics_task4
{
    public class Scoda : ICar
    {
        private string _name;
        private int _year;

        public Scoda(string name, int year)
        {
            _name = name;
            _year = year;
        }
    }
}
