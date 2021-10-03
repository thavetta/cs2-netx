using System;
using Auta;
using NetTopologySuite.Geometries;

namespace AutaDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var toyota100Stribrna = new SpecifikaceAuta("Toyota LC100", 5, "Stribrna");

            var autoA = new Auto() { Specifikace = toyota100Stribrna , PoziceAktualni = new Point(10, 10) };
            var autoB = new Auto() { Specifikace = new SpecifikaceAuta("Toyota LC100", 5, "Stribrna"), PoziceAktualni = new Point(20, 20) };

            //pouziti noveho klicoveho slova "with" pro odvozeni trosku jineho recordu
            var toyota100StribrnaUprava = toyota100Stribrna with { MistNaSezeni = 2 };

            //jak udelat test, ze se jedna o auta ktere jsou stejny model, stejna barva a stejny pocet mist na sezeni
            //a jak garantovat, ze nekdo 'omylem' nezmeni barvu, model ci pocet mist k sezeni

            //Nasledujici kod nelze kompilovat, ochrana pred zmenou funguje
            //autoA.Specifikace.MistNaSezeni++; 

            //Record se automaticky dovede porovnat na obsah
            if (autoA.Specifikace == autoB.Specifikace)
                Console.WriteLine("Auto A a B jsou stejne!");
            else
                Console.WriteLine("Auto A a B jsou ruzne!");
        }
    }
}
