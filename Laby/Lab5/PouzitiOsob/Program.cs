using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Osoby;

namespace PouzitiOsob
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = VratSeznamOsob();
            
            double prumer = SpocitejPrumernyVek(data);
            
            Console.WriteLine("Prumerny vek je " + prumer);
        }

        private static double SpocitejPrumernyVek(List<Osoba> data)
        {
            double suma = 0;
            foreach (Osoba osoba in data)
            {
                suma += osoba.VratAktualnyVek();
            }

            return suma / data.Count;
        }

        private static List<Osoba> VratSeznamOsob()
        {
            List<Osoba> response = new List<Osoba>
            {
                new Osoba(1965) {Jmeno = "Tomas", Prijmeni = "Novak"},
                new Osoba(1972) {Jmeno = "Pavel", Prijmeni = "Kratky"},
                new Osoba(1986) {Jmeno = "Eva", Prijmeni = "Mala"}
            };
            return response;
        }
    }
}
