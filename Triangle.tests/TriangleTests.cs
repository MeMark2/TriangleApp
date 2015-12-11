using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace Triangle.tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void CalcHypotenuseFunctional()
        {
            Triangle tri = new Triangle();
            double hypotenuse = tri.CalcHypotenuse(3.0, 4.0);
            Assert.AreEqual(hypotenuse, 5.0);
        }
    }
}
