using System;

namespace AskForInput
{
    class Program
    {
        /// <summary>
        /// Utilizador digita dois numeros de tipos diferente que se somam
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            string resposta = Console.ReadLine();

            int transfoma = int.Parse(resposta);

            Console.Write("Digite um número real: ");
            string resposta2 = Console.ReadLine();
            float floating = float.Parse(resposta2);

            Console.Write($"{resposta} + {resposta2} = {transfoma + floating}");
        }
    }
}
