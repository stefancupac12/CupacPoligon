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
    }
}
