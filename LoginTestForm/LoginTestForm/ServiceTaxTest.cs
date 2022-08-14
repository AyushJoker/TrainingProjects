using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginTestForm
{
    public class ServiceTaxTest
    {
        ServiceTax tax;
        [SetUp]
        public void create()
        {
            tax = new ServiceTax();
        }
        [TearDown]
        public void destroy()
        {
            tax = null;
        }
        [Test]
        [TestCase(300000.00,36000.00)]
        [TestCase(400000.00,48000.00)]
        [TestCase(40000.00, 78250.00)]
        public void TestTax(double amt,double expected)
        {
            double actual = tax.getServiceTax(amt);
            Assert.AreEqual(expected, actual);

        }

    }
}
