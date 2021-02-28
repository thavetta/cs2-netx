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
    }
}