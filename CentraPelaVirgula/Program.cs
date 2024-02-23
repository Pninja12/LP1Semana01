using System;
using System.Globalization;

namespace CentraPelaVirgula
{
    class Program
    {
        /// <summary>
        /// Programa que pede ao utilizador 4 números reais e os centra à
        /// direita com o máximo de 6 caracteres e com 2 casa decimais
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = 
            CultureInfo.InvariantCulture;

            Console.WriteLine("Insere 4 números reais:");
            string resposta1 = Console.ReadLine(); //Pede 1 numero real
            float n1 = float.Parse(resposta1); //muda essa string para um float
            string resposta2 = Console.ReadLine(); //Pede 1 numero real
            float n2 = float.Parse(resposta2); //muda essa string para um float
            string resposta3 = Console.ReadLine(); //Pede 1 numero real
            float n3 = float.Parse(resposta3); //muda essa string para um float
            string resposta4 = Console.ReadLine(); //Pede 1 numero real
            float n4 = float.Parse(resposta4); //muda essa string para um float
            
            //Imprime todos os floats com 2 casas decimais e encostados à
            //direita com 6 caracteres
            Console.WriteLine($"{n1,6:f2}\n{n2,6:f2}\n{n3,6:f2}\n{n4,6:f2}");
        }
    }
}
