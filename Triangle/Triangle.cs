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
            // Use pythagorean theorem to calculate the hypotenuse
            return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        }


        public double RightCalcArea(double a, double b)
        {
            return a * b / 2;
        }
    }
}
