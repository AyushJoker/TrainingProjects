using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginTestForm
{
    public class GrossSalary
    {
        public double getGrossSalary(int id,string name,double Basic_salary)
        {
            double grossSalary = Basic_salary + 0.2 * Basic_salary + 0.7 * Basic_salary + 1500 + 750;
            return grossSalary; 
        }
    }
}
