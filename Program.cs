using System;

namespace Divisao
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal Numerador;
            decimal Denominador;

            Console.WriteLine("Receba um numerador e um denominador. Exiba o resultado da divisão\n");

            Console.Write("Digite o numerador....: ");
            Numerador = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Digite o denominador..: ");
            Denominador = Convert.ToDecimal(Console.ReadLine());

            if(Denominador == 0)
            {
                Console.WriteLine($"Não e possivel dividir em {Denominador} vez(es).");
                Environment.Exit(-1);
            }

            decimal DivisaoDigitada = Numerador / Denominador;

            Console.WriteLine($"{Numerador} dividido por {Denominador} é {DivisaoDigitada}.");
        }
    }
}
