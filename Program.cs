using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CupacPoligon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stefan Cupac
            /*
            tacka A = new tacka(2, 3);
            tacka B = new tacka(4, 5);
            tacka C = new tacka(6, 7);
            tacka D = new tacka(8, 9);
            vektor AB = new vektor(A, B);
            AB.stampaj();
            */
            /*
            Poligon prvi = Poligon.unos();
            prvi.stampa();
            prvi.snimi();
            */
            //Poligon drugi = Poligon.ucitaj();
            //drugi.stampa();
            //Console.ReadKey();
            tacka A = new tacka(1, 1);
            tacka B = new tacka(5, 1);
            tacka C = new tacka(2, 6);
            tacka D = new tacka(2, 1);
            vektor AB = new vektor(A, B);
            vektor CD = new vektor(C, D);
            Console.WriteLine(AB.sece(CD));
        }
    }
}
