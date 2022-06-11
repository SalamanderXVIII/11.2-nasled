using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._3
{
    internal class Employee : Date
    {
        public string NameSurname;
        public int YearsInActions(int b)
        {
            return DateTime.Now.Year - b;
        }
    }
}
