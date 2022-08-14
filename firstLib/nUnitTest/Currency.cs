using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nUnitTest
{
    public class Currency
    {

        public decimal ConvertToDollar(decimal a)
        {
            return a / 80;
        }

        public decimal ConvertToRupee(decimal a)
        {
            return a * 80;
        }
    }
}
