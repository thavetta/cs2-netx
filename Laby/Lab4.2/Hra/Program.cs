using System;
using Kostky;

namespace Hra
{
    class Program
    {
        static void Main()
        {
            HraciKostka kostka = new HraciKostka { MaxHodnota = 12};
            ZobrazovacZnakem znaky = new ZobrazovacZnakem {Barva = ConsoleColor.Yellow, Znak = 'X'};
            ZobrazovacTextem text = new ZobrazovacTextem();
            
            Console.WriteLine("Můžeš hrát:");
            Console.WriteLine("   h - hod kostkou");
            Console.WriteLine("   1 - výpis textem");
            Console.WriteLine("   2 - výpis znaky");
            Console.WriteLine("   q - konec hry");

            HodEvent(kostka, text.ZobrazKostku, znaky.UkazZnaky);
        }
        
        private static void HodEvent(HraciKostka kostka, 
            EventHandler<PoHoduKostkouEventArgs> volba1,
            EventHandler<PoHoduKostkouEventArgs> volba2)
        {
            EventHandler<PoHoduKostkouEventArgs> posledni = volba1;
            kostka.PoHoduKostkou += volba1;

            ConsoleKeyInfo znak = Console.ReadKey(true);

            while (znak.KeyChar != 'q')
            {
                switch (znak.KeyChar)
                {
                    case '1':
                        kostka.PoHoduKostkou -= posledni;
                        kostka.PoHoduKostkou += volba1;
                        posledni = volba1;
                        break;
                    case '2':
                        kostka.PoHoduKostkou -= posledni;
                        kostka.PoHoduKostkou += volba2;
                        posledni = volba2;
                        break;
                    case 'h':
                        kostka.HodKostkou();
                        break;
                }
                znak = Console.ReadKey(true);
            }
        }
    }
}
