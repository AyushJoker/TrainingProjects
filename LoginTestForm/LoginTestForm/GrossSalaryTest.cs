using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginTestForm
{
    
    public class GrossSalaryTest
    {
        GrossSalary gs;
        [SetUp]
        public void create()
        {
            gs = new GrossSalary();
        }
        [TearDown]
        public void destroy()
        {
            gs = null;
        }
        [Test]
        [TestCase(1,"Rahul",40000.00,78250.00)]
        [TestCase(2,"Ayush",30000.00,59250.00)]
        public void TestSalary(int id,string name,double bs,double expected)
        {
            double actual = gs.getGrossSalary(id, name, bs);
            Assert.AreEqual(expected, actual);
        }
    }
}

