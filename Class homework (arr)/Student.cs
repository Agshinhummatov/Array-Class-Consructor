using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_homework__arr_
{
    internal class Student
    {
        public string name;
        public string surname;
        public int age;
        public string address;
        public string phone;

        public string GetFullname()
        {
            return name+ " "+surname+" "+age;

        }

        
    }

}
