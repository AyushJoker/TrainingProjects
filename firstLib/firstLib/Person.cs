using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace firstLib
{
    public class Person
    {
        public string firstName { get; set; }

        public string lastName { get; set; }

        public string fullName()
        {
            return firstName + " " + lastName;
        }
    }
}