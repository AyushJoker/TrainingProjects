using NUnit.Framework;
using firstLib;
namespace firstLibTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void AddTestMethod()
        {
            //A-Arrange
            int a = 20, b = 30;
            int expected = 50;
            
            //A-Act
            int actualA = MyMath.add(a, b);
            int actualS = MyMath.sub(a, b);
            int expected1 = -10;
            int actualS2= MyMath.sub(40,50);
            //A-Assert
            Assert.AreEqual(expected1, actualS);

        }
    }
}