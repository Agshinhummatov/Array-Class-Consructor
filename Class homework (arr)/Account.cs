using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_homework__arr_
{
    public class Account
    {
        public string name;
        public string password;

        public Account(string name, string password)
        {
            this.name = name;
            this.password = password;

        }

        internal void Sign()
        {
            if(name == "cavid123" && password == "Cavid1993")
            {
                Console.WriteLine("Emeliyyat ugurluur");
            }
            else
            {
                Console.WriteLine("username ve ya password yalnisdir");
            }
        }
    }
}
