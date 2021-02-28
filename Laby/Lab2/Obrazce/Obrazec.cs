using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obrazce
{
    public abstract class Obrazec : IKresleni
    {
        private Bod poloha;

        public Bod Poloha
        {
            get { return poloha; }
            set { poloha = value; }
        }

        private Barvy barva;

        public Barvy Barva
        {
            get { return barva; }
            set
            {
                if (Enum.IsDefined(typeof(Barvy), value))
                    barva = value;
                else
                    throw new InvalidEnumArgumentException("Barva",(int) value, typeof(Barvy));
            }
        }

        private uint vyska;

        public uint Vyska
        {
            get { return vyska; }
            set { vyska = value; }
        }

        private uint sirka;

        public uint Sirka
        {
            get { return sirka; }
            set { sirka = value; }
        }

        public void VykresliSe()
        {
            string typ = VratTyp();
            Vypis(typ);
        }

        protected abstract string VratTyp();

        protected void Vypis(string typ)
        {
            Console.WriteLine("Vykresluji obrazec {0} barvou {1} na pozici {2} o rozmerech {3} x {4}",typ,this.Barva,this.Poloha,this.Sirka,this.Vyska);
        }
    }
}
