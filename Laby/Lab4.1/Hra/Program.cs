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

            HodCallback(kostka, text.ZobrazKostku, znaky.UkazZnaky);
        }
        
        private static void HodCallback(HraciKostka kostka, Action<int> volba1, Action<int> volba2)
        {
            Action<int> callback = volba1;

            ConsoleKeyInfo znak = Console.ReadKey(true);

            while (znak.KeyChar != 'q')
            {
                switch (znak.KeyChar)
                {
                    case '1':
                        callback = volba1;
                        break;
                    case '2':
                        callback = volba2;
                        break;
                    case 'h':
                        kostka.HodKostkou(callback);
                        break;
                }
                znak = Console.ReadKey(true);
            }
        }
    }
}
