using System;

namespace VariousTypes
{
    class Program
    {   
        /// <summary>
        /// Mostra todo o tipo de variáveis dadas na aula
        /// e o seu respetivo valor dado por mim
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Variaveis tipo inteiro
            int var_int = 1;
            Console.WriteLine($"variável int = {var_int}");
            uint var_uint = 2U;
            Console.WriteLine($"variável uint = {var_uint}");
            long var_long = 3L;
            Console.WriteLine($"variável long = {var_long}");
            ulong var_ulong = 4UL;
            Console.WriteLine($"variável ulong = {var_ulong}");
            byte var_byte = 5;
            Console.WriteLine($"variável byte = {var_byte}");
            sbyte var_sbyte = 6;
            Console.WriteLine($"variável sbyte = {var_sbyte}");
            short var_short = 7;
            Console.WriteLine($"variável short = {var_short}");
            ushort var_ushort = 8;
            Console.WriteLine($"variável ushort = {var_ushort}");
            char var_char = '9';
            Console.WriteLine($"variável char = {var_char}");

            //Variaveis unicode
            char AA = '\u0466';
            Console.WriteLine($"Funny looking double A together = {AA}");
            char chatgpt = '\u058D';
            Console.WriteLine($"ChatGPT logo = {chatgpt}");
            char cross = '\u2020';
            Console.WriteLine($"Cross = {cross}");

            //Variaveis inteiras
            double var_double = 10.123456789;
            Console.WriteLine($"Variável double = {var_double}");
            float var_float = 11.987654321f;
            Console.WriteLine($"Variável double = {var_float}");
            decimal var_decimal = 12.59009m;
            Console.WriteLine($"Variável double = {var_decimal}");

            //Variaveis booleanas
            bool var_true = true;
            Console.WriteLine($"Variável bool = {var_true}");
            bool var_false = false;
            Console.WriteLine($"Variável bool = {var_false}");
        }
    }
}
