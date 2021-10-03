using System;
using Auta;
using NetTopologySuite.Geometries;

namespace AutaDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var autoA = new Auto() { Model = "Toyota LC100", MistNaSezeni = 5, Barva = "Stribrna", PoziceAktualni = new Point(10, 10) };
            var autoB = new Auto() { Model = "Toyota LC100", MistNaSezeni = 5, Barva = "Stribrna", PoziceAktualni = new Point(20, 20) };

            //jak udelat test, ze se jedna o auta ktere jsou stejny model, stejna barva a stejny pocet mist na sezeni
            //a jak garantovat, ze nekdo 'omylem' nezmeni barvu, model ci pocet mist k sezeni

            autoA.MistNaSezeni++; 

            if (autoA.Model == autoB.Model && autoA.MistNaSezeni == autoB.MistNaSezeni && autoA.Barva == autoB.Barva)
                Console.WriteLine("Auto A a B jsou stejne!");
            else
                Console.WriteLine("Auto A a B jsou ruzne!");
        }
    }
}
