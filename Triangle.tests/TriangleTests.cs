using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace Triangle.tests
{
    [TestClass]
    public class TriangleTests
    {
        /// <summary>
        /// This test asserts that the CalcHypotenuse method of the triangle is functional.
        /// </summary>
        [TestMethod]
        public void CalcHypotenuseFunctional()
        {
            Triangle tri = new Triangle();
            double hypotenuse = tri.CalcHypotenuse(3.0, 4.0);
            Assert.AreEqual(hypotenuse, 5.0);
        }



        /// <summary>
        /// This test expects an ArguementOutOfRange exception when inputting invalid
        /// arguements into the CalcHypotenuse method of the triangle.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CalcHypotenuseException()
        {
            Triangle tri = new Triangle();
            double hypotenuse = tri.CalcHypotenuse(3.0, 0.0);
        }



        /// <summary>
        /// This test asserts that the RightCalcArea method of the triangle is functional.
        /// </summary>
        [TestMethod]
        public void RightCalcAreaFunctional()
        {
            Triangle tri = new Triangle();
            double area = tri.RightCalcArea(5.0, 4.0);
            Assert.AreEqual(area, 10.0);
        }



        /// <summary>
        /// This test expects an ArguementOutOfRange exception when inputting invalid
        /// arguements into the RightCalcArea method of the triangle.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RightCalcAreaException()
        {
            Triangle tri = new Triangle();
            double area = tri.RightCalcArea(-5.0, 4.0);
        }



        /// <summary>
        /// This test asserts that the CalcThirdAngle method of the triangle is functional.
        /// </summary>
        [TestMethod]
        public void CalcThirdAngleFunctional()
        {
            Triangle tri = new Triangle();
            double thirdAngle = tri.CalcThirdAngle(50.0, 70.0);
            Assert.AreEqual(thirdAngle, 60.0);
        }



        /// <summary>
        /// This test expects an ArgumentException exception when inputting invalid
        /// arguements into the CalcThirdAngle method of the triangle.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalcThirdAngleException()
        {
            Triangle tri = new Triangle();
            double thirdAngle = tri.CalcThirdAngle(100.0, 100.0);
        }



        /// <summary>
        /// This test expects an InvalidOperationException exception when using 
        /// SetRightTriangleSides methods and the triangle is not a right triangle.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void SetRightTriangleSidesException()
        {
            // Triangle is by default not a right triangle when instantiated
            Triangle tri = new Triangle();
            tri.SetRightTriangleSides(1.0, 1.0);
        }
    }
}
