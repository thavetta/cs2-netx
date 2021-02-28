using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Osoby;

namespace PouzitiOsob
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = VratSeznamOsob();
            
            double prumer = data.Average(x => x.VratAktualnyVek());
            
            Console.WriteLine("Prumerny vek je " + prumer);

            Console.WriteLine("Osoby setridene dle platu:");

            IEnumerable<Osoba> query = data.OrderBy(x => x.Plat);
            Vypis(query);

            query = data.Where(x => x.RokNarozeni > 1980);
            Console.WriteLine("Osoby narozene po roce 1980:");
            Vypis(query);

            int sumaVeku = data.Where(x => x.Plat > 30000).Sum(x => x.VratAktualnyVek());
            Console.WriteLine("Suma věku lidi s platem nad 30000 Kc: " + sumaVeku);

            var xmldata = VytvorXml(data);
            Console.WriteLine(xmldata);

        }

        private static XElement VytvorXml(IEnumerable<Osoba> data)
        {
            XElement root = new XElement("seznam",
                from x in data
                select new XElement("osoba",
                    new XAttribute("id",x.ID),
                    new XElement("jmeno", x.Jmeno),
                    new XElement("prijmeni",x.Prijmeni)
                    ));
            return root;
        }

        private static void Vypis(IEnumerable<Osoba> query)
        {
            foreach (var osoba in query)
            {
                Console.WriteLine(osoba);
            }
        }

        private static List<Osoba> VratSeznamOsob()
        {
            List<Osoba> response = new List<Osoba>
            {
                new Osoba(1965) {Jmeno = "Tomas", Prijmeni = "Novak", Plat = 35000},
                new Osoba(1972) {Jmeno = "Pavel", Prijmeni = "Kratky", Plat = 30000},
                new Osoba(1986) {Jmeno = "Eva", Prijmeni = "Mala", Plat = 25000},
                new Osoba(1966) {Jmeno = "Jana", Prijmeni = "Konecna", Plat = 33000},
                new Osoba(1990) {Jmeno = "Petr", Prijmeni = "Horak", Plat = 35000},
                new Osoba(1975) {Jmeno = "Elena", Prijmeni = "Kralova", Plat = 33000},

            };
            return response;
        }
    }
}
