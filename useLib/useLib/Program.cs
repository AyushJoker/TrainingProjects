using System;
using firstLib;

namespace uselib
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Add is {0}", MyMath.add(2, 3));



            Person p = new Person() { firstName = "Rahul", lastName = "Bajetha" };


            Console.WriteLine(p.fullName());



            Currency c = new Currency();



            Console.WriteLine("80.2 Rupees = {0:C} Dollar", c.ConvertToDollar(80.2m));
            Console.WriteLine("1.3 Dollar = {0:C} Rupees", c.ConvertToRupee(1.3m));

        }
    }
}