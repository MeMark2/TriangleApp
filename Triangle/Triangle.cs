using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    public class Triangle
    {
        /// <summary>
        /// This method will calculate the hypotenuse of a right triangle given 
        /// the length of the other 2 sides.
        /// </summary>
        /// <param name="a">the length of one of the sides (not the hypotenuse)</param>
        /// <param name="b">the length of the other side (not the hypotenuse)</param>
        /// <returns>the hypotenuse as a double</returns>
        public double CalcHypotenuse(double a, double b)
        {
            // Throw exception if the values cant be used to calculate the hypotenuse
            if (a <= 0.0 || b <= 0.0)
            {
                throw new ArgumentOutOfRangeException();
            }

            // Use pythagorean theorem to calculate the hypotenuse
            return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        }



        /// <summary>
        /// This method calculates the area of a right triangle given the
        /// length of the two shorter sides.
        /// </summary>
        /// <param name="a">the length of one of the sides (not the hypotenuse)</param>
        /// <param name="b">the length of the other side (not the hypotenuse)</param>
        /// <returns>the area of the triangle as a double</returns>
        public double RightCalcArea(double a, double b)
        {
            // Throw exception if the values cant be used to calculate the area
            if (a <= 0.0 || b <= 0.0)
            {
                throw new ArgumentOutOfRangeException();
            }

            // Calculate the area of a right triangle
            return a * b / 2;
        }



        /// <summary>
        /// This method calculates the angle of a triangle given the other two angles.
        /// </summary>
        /// <param name="a">the degrees of one of the angles</param>
        /// <param name="b">the degrees of another of the angles</param>
        /// <returns>the degrees of the third angle as a double</returns>
        public double CalcThirdAngle(double a, double b)
        {
            if (a + b >= 180.0 || a <= 0.0 || b <= 0.0)
            {
                throw new ArgumentException();
            }

            // All angles must add up to 180.0 degrees
            return (180.0 - a) - b;
        }
    }
}
