using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CupacPoligon
{
    internal class vektor
    {
        public tacka pocetak;
        public tacka kraj;
        public tacka centriraj() 
        {
            double x = kraj.x - pocetak.x;
            double y = kraj.y -pocetak.y;
            return new tacka(x, y);
        }
        public void stampaj()
        {
            Console.WriteLine("Od x1={0}, y1={1} Do x2={2}, y2={3}", pocetak.x, pocetak.y, kraj.x, kraj.y);
        }
        public vektor(tacka a, tacka b) 
        {
            pocetak = a;
            kraj = b;
        }
    }
}
