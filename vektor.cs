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
        public static double SP(vektor a, vektor b)
        {
            tacka A = a.centriraj();
            tacka B = b.centriraj();
            return A.x * B.x + A.y * B.y;
        }
        public static double VP(vektor a, vektor b)
        {
            tacka A = a.centriraj();
            tacka B = b.centriraj();
            double k = A.x * B.y - A.y * B.x;
            return k;
        }
        public double duzina()
        {
            tacka druga = this.centriraj();
            return druga.d();
        }
        public bool sece(vektor b)
        {
            int x = ravan.SIS(this, b.pocetak, b.kraj);
            int y = ravan.SIS(b, this.pocetak, this.kraj);
            if (x * y != 0) return true;
            else return false;
        }
    }
}
