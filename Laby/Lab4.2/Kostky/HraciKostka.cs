using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kostky
{
    public class HraciKostka
    {
        private int hodnota = 1;
        private int maxHodnota = 7;
        private Random generator = new Random();
        public int Hodnota
        {
            get { return hodnota; }
        }

        public int MaxHodnota
        {
            get { return maxHodnota; }
            set
            {
                if (value > 1)
                {
                    maxHodnota = value + 1;
                    if (hodnota > maxHodnota)
                        hodnota = maxHodnota;
                }
            }
        }

        public void HodKostkou()
        {
            this.hodnota = generator.Next(1, maxHodnota);
            OnPoHoduKostkou(this.hodnota);
        }

        public event EventHandler<PoHoduKostkouEventArgs>? PoHoduKostkou;

        protected virtual void OnPoHoduKostkou(int hodnota)
        {
            PoHoduKostkou?.Invoke(this,new PoHoduKostkouEventArgs() {Hodnota = hodnota});
        }

    }
}
