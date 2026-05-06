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
            tacka a = new tacka(1, 1);
            tacka b = new tacka(3, 1);
            tacka c = new tacka(3, 5);
            tacka d = new tacka(1, 5);

            vektor AB = new vektor(a, b);
            vektor CD = new vektor(c, d);
            vektor DA = new vektor(d, a);
            vektor BC = new vektor(b, c);
            
            double ab_len = AB.duzina();
            double bc_len = BC.duzina();
            double cd_len = CD.duzina();
            double da_len = DA.duzina();

            tacka[] temena = { a, b, c, d };
            int br_temena = temena.Length;
            

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
                Console.WriteLine("jeste deltoid: AB=DA");
            }
            else
            if ((ab_len == bc_len) && (cd_len == da_len))
            {
                Console.WriteLine("Jeste deltoid AB=BC");
            }
            else Console.WriteLine("nije deltoid");
            if (vektor.VP(AB, CD) == 0)
            {
                if ((vektor.SP(AB, BC) == 0 && vektor.SP(BC, CD) == 0 && vektor.SP(CD, DA) != 0) ||
                    (vektor.SP(CD, DA) == 0 && vektor.SP(DA, AB) == 0 && vektor.SP(AB, BC) != 0))
                {
                    Console.WriteLine("Jeste pravougli trapez");
                }
                else Console.WriteLine("Nije pravougli trapez");
            }
            else if (vektor.VP(BC, DA) == 0)
            {
                if ((vektor.SP(BC, AB) == 0 && vektor.SP(AB, DA) == 0 && vektor.SP(DA, CD) != 0) ||
                    (vektor.SP(DA, CD) == 0 && vektor.SP(CD, BC) == 0 && vektor.SP(BC, AB) != 0))
                {
                    Console.WriteLine("Jeste pravougli trapez ");
                }
                else Console.WriteLine("Nije pravougli trapez");
            }
            else
            {
                Console.WriteLine("Nije pravougli trapez");
            }
            double plus = 0;
            double minus = 0;
            for (int i = 0; i < br_temena; i++)
            {
                double x1 = temena[i].x;
                double y1 = temena[i].y;
                double x2 = temena[(i + 1) % br_temena].x;
                double y2 = temena[(i + 1) % br_temena].y;
                plus += x1 * y2;
                minus += y1 * x2;
            }

            double povrsina = Math.Abs((plus - minus) / 2.0);

            Console.WriteLine("Površina je: " + povrsina);
        }
    }
    
}
