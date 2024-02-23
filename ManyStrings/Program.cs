using System;

namespace ManyStrings
{
    class Program
    {
        /// <summary>
        /// Algumas variáveis do tipo string 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string ola = "Olá \\o";
            Console.WriteLine($"{ola}");
            string ola_unicode = "\u24C4 \u24C1 \u24B6";
            Console.WriteLine($"{ola_unicode}");
            string paulo = "\u24C5 \u24B6 \u24CA \u24C1 \u24C4";
            Console.WriteLine($"{paulo}");
            string conversa = "Como estás? \nCorreu bem o dia?";
            Console.WriteLine($"{conversa}");
        }
    }
}
