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



        [TestMethod]
        public void RightCalcAreaFunctional()
        {
            Triangle tri = new Triangle();
            double area = tri.RightCalcArea(5.0, 4.0);
            Assert.AreEqual(area, 10.0);
        }


        [TestMethod]
        public void CalcThirdAngleFunctional()
        {
            Triangle tri = new Triangle();
            double thirdAngle = tri.CalcThirdAngle(50.0, 70.0);
            Assert.AreEqual(thirdAngle, 60.0);
        }
    }
}
