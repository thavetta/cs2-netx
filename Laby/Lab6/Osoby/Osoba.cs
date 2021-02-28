using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;


namespace Osoby
{
    public class Osoba 
    {
        public int ID { get; }
        private string jmeno = string.Empty;

        public string Jmeno
        {
            get { return jmeno; }
            set
            {
                if (jmeno != value)
                {
                    if (!string.IsNullOrWhiteSpace(value))
                        jmeno = value;
                }
            }
        }

        public string Prijmeni { get; set; } = string.Empty;
        public string PlneJmeno => Jmeno + " " + Prijmeni;
        public int RokNarozeni { get; private set; }
        public int? Plat { get; set; }

        public void OpravRok(int rok)
        {
            RokNarozeni = rok;
        }

        private static int pocitadloID = 0;
        public Osoba()
        {
            ID = Interlocked.Increment(ref pocitadloID); 
        }

        public Osoba(int rok) : this()
        {
            RokNarozeni = rok;
        }

        public override string ToString()
        {
            return $"{PlneJmeno} - {RokNarozeni} - {Plat}";
        }
    }
}
