using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace towerDefense
{
    public class Point
    {

        public readonly int X;
        public readonly int Y;
        
       public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int DistanceTo(int x, int y)
        {
            int xDiff = X - x;
            int yDiff = Y - y;

            int xDiffSqrt = xDiff * xDiff;
            int yDiffSqrt = yDiff * yDiff;

            return (int) Math.Sqrt(xDiffSqrt + yDiffSqrt);

            /* shorter version of carthesian distance formula
             * return (int)Math.Sqrt(Math.Pow (X-x,2) + Math.Pow(Y-y, 2)); */
        }

        //O-O-O-O-O-OVERLOAAAAAAAADDDDD the fudge out of DistanceTo!!
        public int DistanceTo(Point point)
        {
            return DistanceTo(point.X, point.Y);
        }


    }
}
