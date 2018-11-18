using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckTriangle
{
    public class Triangle
    {
        public static bool CheckTriangle(double firstSide, double secondSide, double thirdSide)
        {
            double[] sides = new double[3];

            sides[0] = firstSide;
            sides[1] = secondSide;
            sides[2] = thirdSide;

            if (sides != null)
                Array.Sort(sides);

            if (sides != null
                && sides[0] != sides[2]
                && sides[1] != sides[2]
                && sides[0] != 0
                && sides[1] != 0
                && sides[2] != 0
                && (sides[0] + sides[1] == sides[2]))
                return true;
            else
                return false;
        }
    }
}
