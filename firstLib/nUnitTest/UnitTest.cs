using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace nUnitTest
{

    public class UnitTest
    {
        Area area;
        [SetUp]
        public void Setup()
        {
            area = new Area();
        }
        [TearDown]
        public void Closup()
        {
            area = null;
        }
        [Test]
        public void CircleTest()
        {
            //Arrange
            int r = 5;
            double expected = 36;
            double actual = area.Circle(r);
            Assert.AreEqual(expected, actual, 1, "value not match");

        }
        public void RectangleTest()
        {
            //Arrange
            int l = 5,b=6;
            double expected = 30;
            double actual = area.Rectangle(l,b);
            Assert.AreEqual(expected, actual, 1, "value not match");

        }
    }
}
