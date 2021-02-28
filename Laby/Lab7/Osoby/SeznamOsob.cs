using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osoby
{
    public class SeznamOsob : IEnumerable<Osoba>
    {
        private readonly List<Osoba> seznam = new List<Osoba>();

        public void PridejOsobu(Osoba osoba)
        {
            if (seznam.Contains(osoba))
                return;
            seznam.Add(osoba);

        }

        public IEnumerator<Osoba> GetEnumerator()
        {
            return seznam.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
