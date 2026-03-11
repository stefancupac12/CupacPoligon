using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CupacPoligon
{
    internal class tacka
    {
        double x;
        double y;
        public double d()
        {
            return Math.Sqrt(x * x + y * y);
        }
        public tacka(double a, double b)
        {
            x = a;
            y = b;
        }
    }
}
