using System;
using Osoby;

namespace PouzitiOsob
{
    public static class Utils
    {
        public static int VratAktualnyVek(this Osoba osoba)
        {
            return DateTime.Now.Year - osoba.RokNarozeni;
        }

        public static void Add(this SeznamOsob seznam, Osoba osoba)
        {
            seznam.PridejOsobu(osoba);
        }

        //Metoda umožní přiřadit instanci Osoba do ValueTuple<int, string, string>
        public static void Deconstruct(this Osoba osoba, out int id, out string prijmeni, out string jmeno )
        {
            id = osoba.ID;
            jmeno = osoba.Jmeno;
            prijmeni = osoba.Prijmeni;
        }
    }
}