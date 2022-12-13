using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_homework__arr_
{
    internal class Factorial
    {
        public int number;


        internal void FactorialNumber(int number) 
        {
            int multiple = 1;
            for (int i = 1; i <= number; i++)
            {
                multiple *= i;
            }

            Console.WriteLine( multiple);
        }
    }
}
