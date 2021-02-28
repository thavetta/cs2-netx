using System;
using Kostky;

namespace Hra
{
    class ZobrazovacTextem
    {
        public void ZobrazKostku(int hodnota)
        {
            Console.WriteLine("Na kostce je cislo " + hodnota);
        }

        public void ZobrazKostku(object sender, PoHoduKostkouEventArgs e)
        {
            ZobrazKostku(e.Hodnota);
        }

    }

}
