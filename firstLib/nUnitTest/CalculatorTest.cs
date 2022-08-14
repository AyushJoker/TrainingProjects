using NUnit.Framework;
using firstLib;
using firstLibTest;
namespace nUnitTest
{
    [TestFixture]
    public class CalculatorTest
    {
        [Test]
        [TestCase(15,35,50)]
        [TestCase(10, 45, 55)]
        [TestCase(25, 35, 60)]
        public void AddTestMethod(int num1,int num2,int expected)
        {
            Calculator Add = new Calculator();
            int Aresult = Add.Add(num1, num2);
            Assert.AreEqual(expected, Aresult);
        }
        [Test]
        [TestCase(25, 35, -10)]
        [TestCase(10, 45, -35)]
        [TestCase(55, 35,20)]
        public void SubTestMethod(int num1, int num2, int expected)
        {
            Calculator Subtract = new Calculator();
            int Sresult = Subtract.Sub(num1, num2);
            Assert.AreEqual(expected, Sresult);
        }
        [Test]
        [TestCase(8, 640)]
        [TestCase(40, 3200)]
        [TestCase(5, 400)]
        public void ConvertCrncyToRupeesTest(decimal num1, int expected)
        {
            Currency c = new Currency();
            decimal Rupees = c.ConvertToRupee(num1);
            Assert.AreEqual(expected, Rupees);
        }
        [Test]
        [TestCase(640,8)]
        [TestCase(3200,40)]
        [TestCase(400,5)]
        public void ConvertCrncyToDollorsTest(decimal num1, int expected)
        {
            Currency c = new Currency();
            decimal Dollors = c.ConvertToDollar(num1);
            Assert.AreEqual(expected, Dollors);
        }
    }
}