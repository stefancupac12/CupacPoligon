using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CupacPoligon
{
    internal class tacka
    {
        public double x;
        public double y;
        public double d()
        {
            return Math.Sqrt(x * x + y * y);
        }
        public tacka(double a, double b)
        {
            x = a;
            y = b;
        }
        public static bool iste(tacka A, tacka B)
        {
            if ((A.x == B.x) && (A.y == B.y)) return true;
            else return false;
        }
    }
}
