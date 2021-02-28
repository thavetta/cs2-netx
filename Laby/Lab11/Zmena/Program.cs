using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Zmena
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 4)
            {
                ErrorInfo("Nejsou vsechny parametry");
                return;
            }
            string inputFile = args[0];
            string hledam = args[1];
            string menim = args[2];
            string cilFile = args[3];
	        string heslo = args[4];

            if (!File.Exists(inputFile))
            {
                ErrorInfo("Vstupni soubor " + inputFile + " neexistuje");
                return;
            }

            if (File.Exists(cilFile))
            {
                Console.WriteLine("Vystupni soubor existuje. Chcete ho prepsat?");
                ConsoleKeyInfo cki = Console.ReadKey();
                if (cki.KeyChar != 'a')
                {
                    return;
                }
            }

            Zamena(inputFile, cilFile, hledam, menim);

			Sifrovac.EncryptFile(cilFile,"sifra.bin",heslo);
			Sifrovac.DecryptFile("sifra.bin","desifra.txt",heslo);

            Console.WriteLine("HOTOVO");

        }

        private static void Zamena(string inputFile, string cilFile, string hledam, string menim)
        {
            using (var fsVstup = File.OpenText(inputFile))
            using (var fsVystup = File.CreateText(cilFile))
            {
                Regex reg = new Regex(hledam);

                string radek = fsVstup.ReadLine();
                while (radek != null)
                {
                    string vystup = reg.Replace(radek, menim);
                    fsVystup.WriteLine(vystup);
                    radek = fsVstup.ReadLine();
                }

                fsVstup.Close();
                fsVystup.Close();
            }
        }

        private static void ErrorInfo(string errorInfo)
        {
            Console.WriteLine(errorInfo);
            Console.WriteLine("Tady bude popis parametru");
        }
    }
}
