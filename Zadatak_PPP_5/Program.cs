using System;

namespace Zadatak_PPP_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Ekipa ekipa = new Ekipa("naziv", "Ime");
            Fudaler novi = new Fudaler("Pera", "Petrovic", 2, 14, 27, "Bek");
            Fudaler novi1 = new Fudaler("Nenad", "Nenadovic", 0, 0, 44, "Golman");
            Fudaler novi2 = new Fudaler("Jovan", "Petrovic", 4, 6, 34, "Napadac");
            Fudaler novi3 = new Fudaler("Pera", "Dragovic", 7, 5, 17, "Spic");

            ekipa[0] = novi;
            ekipa[1] = novi1;
            ekipa[2] = novi2;
            ekipa[3] = novi3;

            Console.WriteLine("Prosek golova po igracu je: " +ekipa.prosekGolovaPoIgracu());
            Console.WriteLine("Najstariji igrac je: " + ekipa.vratiNajstarijeg().Ime);


            Console.ReadKey();

        }
    }
}
