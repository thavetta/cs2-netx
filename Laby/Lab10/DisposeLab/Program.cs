using System;
using static System.Console;

namespace DisposeLab
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoDispose();
            ReadKey();

            //Vzhledem k optimalizacim .NET 5 je nutno instancovat class v metodě
            DemoBezDispose();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            WriteLine("Po vycisteni RAM 2");
            ReadKey();
        }

        

        private static void DemoDispose()
        {
            var dp = new Zaklad();
            WriteLine("Generace = " + GC.GetGeneration(dp));
            GC.Collect();
            WriteLine("Generace = " + GC.GetGeneration(dp));
            GC.Collect();
            WriteLine("Generace = " + GC.GetGeneration(dp));
            GC.Collect();
            WriteLine("Generace = " + GC.GetGeneration(dp));
            GC.Collect();
            ReadKey();
            dp.Akce();
            dp.Dispose();
            try
            {
                dp.Akce();
            }
            catch (Exception ex)
            {
                WriteLine(ex.ToString());
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            WriteLine("Po vycisteni RAM");
            
        }

        private static void DemoBezDispose()
        {
            Zaklad? dp;
            dp = new Zaklad();
            dp = null;
        }
    }
}
