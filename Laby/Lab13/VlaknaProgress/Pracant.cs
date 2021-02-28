using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VlaknaProgress
{
    public class Pracant
    {
        public string DlouhaAkceBezVlaken(int data, ProgressBar? pbinfo = null)
        {
            for (int i = 1; i < 11; i++)
            {
                Thread.Sleep(500);
                if (pbinfo is not null)
                    pbinfo.Value = i * 10;
            }

            return "Hotovo " + data;
        }

        public string DlouhaAkceProgress(int data, IProgress<int>? pbinfo = null)
        {
            for (int i = 1; i < 11; i++)
            {
                Thread.Sleep(500);
                if (pbinfo is not null)
                    pbinfo.Report( i * 10);
            }

            return "Hotovo " + data;
        }
    }
}
