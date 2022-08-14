using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginTestForm
{
    public class ServiceTax
    {
        public double getServiceTax(double amount)
        {
            return amount * 0.12; 
        }
    }
}
