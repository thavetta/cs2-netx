using System;

namespace Hra
{
    class ZobrazovacZnakem
    {
        private char znak = '*';

        public char Znak
        {
            get { return znak; }
            set { znak = value; }
        }

        private ConsoleColor barva = ConsoleColor.Yellow;

        public ConsoleColor Barva
        {
            get { return barva; }
            set { barva = value; }
        }

        

        public void UkazZnaky(int hodnota)
        {
            ConsoleColor origColor = Console.ForegroundColor;
            Console.ForegroundColor = barva;

            for (int i = 0; i < hodnota; i++)
            {
                Console.Write(znak);
            }
            Console.WriteLine();

            Console.ForegroundColor = origColor;
        }

    }
}
