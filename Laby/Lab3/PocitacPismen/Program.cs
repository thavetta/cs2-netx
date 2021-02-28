using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace PocitacPismen
{
    class Program
    {
        static void Main(string[] args)
        {
            string vstup = "mama ma maso, my sa mame, tata se ma taky";
        
            IEnumerable<KeyValuePair<char, int>> seznam = SpocitejVyskytPismen(vstup);
	        
			Vypis(seznam);
			IEnumerable<KeyValuePair<int, List<char>>> zoznamByPocet = UsporadejPodlePoctu(seznam);

			VypisDruhySeznam(zoznamByPocet);
        }

        private static void VypisDruhySeznam(IEnumerable<KeyValuePair<int, List<char>>> zoznamByPocet)
        {
            Console.WriteLine("Počet výskytů - písmena s daným počtem výskytů");
            foreach (KeyValuePair<int, List<char>> keyValuePair in zoznamByPocet)
            {
                Console.Write(keyValuePair.Key + " -");
                foreach (char c in keyValuePair.Value)
                {
                    Console.Write(" " + c);
                }

                Console.WriteLine();
            }
        }

        private static IEnumerable<KeyValuePair<int, List<char>>> UsporadejPodlePoctu(IEnumerable<KeyValuePair<char, int>> seznam)
        {
            SortedDictionary<int,List<char>> result = new SortedDictionary<int, List<char>>();

            foreach (KeyValuePair<char, int> keyValuePair in seznam)
            {
                if (result.ContainsKey(keyValuePair.Value))
                {
                    result[keyValuePair.Value].Add(keyValuePair.Key);
                }
                else
                {
                    result.Add(keyValuePair.Value,new List<char>() {keyValuePair.Key});
                }
            }

            return result;
        }

        private static void Vypis(IEnumerable<KeyValuePair<char, int>> seznam)
        {
            Console.WriteLine("Pismeno - Pocet vyskytu");
            foreach (KeyValuePair<char, int> keyValuePair in seznam)
            {
                Console.WriteLine(keyValuePair.Key + " - " + keyValuePair.Value);
            }

            Console.WriteLine("*************************************");
        }

        private static IEnumerable<KeyValuePair<char, int>> SpocitejVyskytPismen(string vstup)
        {
            SortedDictionary<char, int> result = new SortedDictionary<char, int>();

            foreach (char c in vstup)
            {
                if (!Char.IsLetterOrDigit(c))
                    continue;

                if (result.ContainsKey(c))
                {
                    result[c]++;
                }
                else
                {
                    result.Add(c, 1);
                }
            }

            return result;

            //var result = from x in vstup
            //	where Char.IsLetterOrDigit(x)
            //	group x by x
            //	into g
            //	orderby g.Key
            //	select new { Znak = g.Key, Pocet = g.Count() };

            //var result =
            //	vstup.Where((x,i) => Char.IsLetterOrDigit(x) && i > -1)
            //		.GroupBy(x => x)
            //		.OrderBy(g => g.Key)
            //		.Select((g) => new { Znak = g.Key, Pocet = g.Count() });




            //      return result.ToDictionary((x)=>x.Znak,(x)=>x.Pocet);
        }
    }
}
