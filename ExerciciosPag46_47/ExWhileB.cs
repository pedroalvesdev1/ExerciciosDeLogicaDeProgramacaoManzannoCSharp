using System;
using System.Diagnostics.Contracts;

namespace ExerciciosDeLogicaDeProgramacaoManzannoCSharp.ExerciciosPag46_47
{
    internal class ExWhileB
    {
        public static void Main(string[] args)
        {
            int contador = 1;
            int totalPontos = 0;
            while (contador < 101)
            {
                totalPontos = totalPontos + contador;
                contador++;
            }

            Console.WriteLine($"Você precisa de {totalPontos} XP para chegar ao nível 100.");
        }
    }
}
