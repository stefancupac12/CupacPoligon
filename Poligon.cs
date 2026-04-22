using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CupacPoligon
{
    internal class Poligon
    {
        int br_temena;
        tacka[] teme;
        public Poligon(int n)
        {
            br_temena = n;
            teme = new tacka[n];
        }
        public static Poligon unos()
        {
            Console.WriteLine("Unesite broj temena=");
            int br = Convert.ToInt32(Console.ReadLine());
            Poligon novi = new Poligon(br);
            for (int i = 0; i < br; i++)
            {
                Console.WriteLine("Teme({0}).x", i + 1); 
                double x = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Teme({0}).y", i + 1);
                double y = Convert.ToDouble(Console.ReadLine());

                novi.teme[i] = new tacka(x, y);
            }
            return novi;
        }
        public void stampa()
        {
            Console.WriteLine("Poligon sa " + br_temena + " temena:");
            for (int i = 0; i < br_temena; i++)
            {
                Console.WriteLine("x={0} y={1}", teme[i].x, teme[i].y);
            }
        }
        public void snimi()
        {
            StreamWriter izlaz = new StreamWriter("poligon.txt");
            izlaz.WriteLine(br_temena);
            for (int i = 0; i < br_temena; i++)
            {
                izlaz.WriteLine(teme[i].x);
                izlaz.WriteLine(teme[i].y);
            }
            izlaz.Close();
        }
        static public Poligon ucitaj()
        {
            StreamReader ulaz = new StreamReader("poligon.txt");
            int br = Convert.ToInt32(ulaz.ReadLine());
            Poligon novi = new Poligon(br);
            for (int i = 0; i < br; i++)
            {
                double x = Convert.ToDouble(ulaz.ReadLine());
                double y = Convert.ToDouble(ulaz.ReadLine());
                novi.teme[i] = new tacka(x, y);
            }
            ulaz.Close();
            return novi;
        }
        public double obim()
        {
            vektor a;
            double obim = 0;
            for (int i = 0; i < br_temena - 1; i++)
            {
                a = new vektor(teme[i], teme[i + 1]);
                obim += a.duzina();
            }
            a = new vektor(teme[br_temena - 1], teme[0]);
            obim += a.duzina();
            return obim;
        }
        public bool prost()
        {
            for (int i = 0; i < br_temena - 1; i++)
            {
                for (int j = i + 1; j < br_temena; j++)
                {
                    if (tacka.iste(teme[i], teme[j])) return false;
                }
            }
            vektor[] stranica = new vektor[br_temena];
            // napravim stranice
            for (int i = 0; i < br_temena - 2; i++)
            {
                int kraj = br_temena;
                if (i == 0) kraj = br_temena - 1;
                for (int j = i + 2; j < kraj; j++)
                {
                    if (stranica[i].sece(stranica[j])) return false;
                }
            }
            return true;
        }
        public bool konveksan()
        {
            int t = 0;
            for (int i = 0; i< br_temena; i++)
            {
                vektor prvi = new vektor(teme[i], teme[(i +  1)%br_temena]);
                vektor drugi = new vektor(teme[(i + 1)% br_temena], teme[(i + 2)%br_temena]);
                if (vektor.VP(prvi, drugi) > 0) t++;
            }
            if ((t == br_temena) || (t == 0)) return true;
            return false;
        }
        public double povrsina()
        {
            {
                double plus = 0;
                double minus = 0;
                for (int i = 0; i < br_temena; i++)
                {
                    plus += teme[i].x * teme[(i + 1) % br_temena].y;
                    minus += teme[i].y * teme[(i + 1) % br_temena].x;
                }
                return Math.Abs(plus - minus) / 2;
            }

        }
    }
}
