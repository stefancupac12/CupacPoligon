using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CupacPoligon
{
    internal class ravan
    {
        public static int SIS(vektor a, tacka b, tacka c)
        {
            vektor AB
                = new vektor(a.pocetak, b);
            vektor AC = new vektor(a.pocetak, c);
            double aAB = vektor.VP(a, AB);
            double aAC = vektor.VP(a, AC);
            if (aAC * aAB > 0) return 1;  //sa iste
            if (aAC * aAB < 0) return -1;  //razne strane
            return 0;  //jedna tacka lezi na vektoru
        }
    }
}
