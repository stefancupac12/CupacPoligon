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
            /*
            tacka A = new tacka(1, 1);
            tacka B = new tacka(5, 1);
            tacka C = new tacka(2, 6);
            tacka D = new tacka(2, 1);
            vektor AB = new vektor(A, B);
            vektor CD = new vektor(C, D);
            Console.WriteLine(AB.sece(CD));
            */
            /*
            Poligon prvi = Poligon.unos();
            Console.WriteLine(prvi.povrsina());
            // if (prvi.prost())
            //    Console.WriteLine(prvi.povrsina());
            // else Console.WriteLine("nije prost");
            */
            tacka a = new tacka(1, 3);
            tacka b = new tacka(1, 1);
            tacka c = new tacka(5, 1);
            tacka d = new tacka(5, 3);
            vektor AB = new vektor(a, b);
            vektor CD = new vektor(c, d);
            vektor DA = new vektor(d, a);
            vektor BC = new vektor(b, c);
            
            double ab_len = AB.duzina();
            double bc_len = BC.duzina();
            double cd_len = CD.duzina();
            double da_len = DA.duzina();
            
            if ((ab_len == bc_len) && (bc_len == cd_len) && (cd_len == da_len))
                if (vektor.SP(AB, BC) == 0)
                    Console.WriteLine("jeste kvadrat");
                else Console.WriteLine("nije kvadrat");
            else Console.WriteLine("nije kvadrat");

            if ((ab_len == cd_len) && (bc_len == da_len))
            {
                if (vektor.SP(AB, BC) == 0)
                {
                    Console.WriteLine("jeste pravougaonik");
                }
                else Console.WriteLine("nije pravougaonik");
            }
            else Console.WriteLine("nije pravougaonik");
            
            if ((ab_len == da_len) && (bc_len == cd_len))
            {
                Console.WriteLine("jeste deltoid: ab=da");
            }
            else
            if ((ab_len == bc_len) && (cd_len == da_len))
            {
                Console.WriteLine("Jeste deltoid AB=BC");
            }
            else Console.WriteLine("nije deltoid"); ;
        }
    }
}
