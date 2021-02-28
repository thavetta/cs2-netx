using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisposeLab
{
    class Zaklad : IDisposable
    {
        private bool disposed = false;

        public void Akce()
        {
            if (disposed)
                throw new ObjectDisposedException("Objekt uz byl uvolnen");

            Console.WriteLine("Provadim Akci");
        }

        public void Close()
        {
            Dispose();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                Console.WriteLine("Taraz uvolnujem managed zdroje");
            }

            Console.WriteLine("Teraz uvolnujem unmanaged zdroje");

            disposed = true;
        }

        ~Zaklad()
        {
            Console.WriteLine("Destruktor");
            Dispose(false);
        }
    }
}
