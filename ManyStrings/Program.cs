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
            //Ex6 variaveis
            double xx = 1.23456;
            int ii = 19;


            //Ex4
            string ola = "Olá \\o";
            Console.WriteLine($"{ola}");
            string ola_unicode = "\u24C4 \u24C1 \u24B6";
            Console.WriteLine($"{ola_unicode}");
            string paulo = "\u24C5 \u24B6 \u24CA \u24C1 \u24C4";
            Console.WriteLine($"{paulo}");
            string conversa = "Como estás? \nCorreu bem o dia?";
            Console.WriteLine($"{conversa}");

            //Ex5
            string num = "Numeros:" + 1 + 2 + 3;
            string num_num = "Todos os " + num;

            string numeros = $"{num_num}, isto é que é muito numero";
            string numeros_dos_numeros = $"{num + numeros}, ya acho que "+
            "estou sem criatividade";

            Console.WriteLine($"{num}\n{num_num}\n" + numeros);
            Console.WriteLine(numeros_dos_numeros);

            //Ex6
            Console.WriteLine($"xx = {xx}\nxx com 2 casas decimais = {xx:f2}");
            Console.WriteLine($"xx em percent. com 1 casa decimal = {xx:p1}");
            Console.WriteLine($"ii = {ii}\nii em hexadecimal = {ii:x}");
            Console.WriteLine($"ii em valor monetário = {ii:c}");
        }
    }
}
