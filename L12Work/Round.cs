using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L12Work
{
    static class Round
    {
        static public double GetCircleLength(double r)
        {
            return 2 * r * Math.PI;
        }

        static public double GetCircleSquare(double r)
        {
            return r * r * Math.PI;
        }

        static public bool IsPointInCircle(double x, double y, double r, double x0, double y0)
        {
            if ((x - x0) * (x - x0) + (y - y0) * (y - y0) <= r * r)
                return true;
            else return false;
        }
    }
}
