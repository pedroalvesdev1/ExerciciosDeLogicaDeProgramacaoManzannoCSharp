using System;
using System.Diagnostics.Contracts;

namespace ExerciciosDeLogicaDeProgramacaoManzannoCSharp.ExerciciosPag46_47
{
    internal class ExWhileC
    {
        public static void Main(string[] args)
        {
            int contador = 1;
            int acumuladora = 0;

            while (contador < 501)
            {
                if (contador % 2 == 0)
                {
                    acumuladora += contador;
                }
                contador++;
            }

            Console.WriteLine($"A soam dos ID's é {acumuladora}");
        }
    }
}
