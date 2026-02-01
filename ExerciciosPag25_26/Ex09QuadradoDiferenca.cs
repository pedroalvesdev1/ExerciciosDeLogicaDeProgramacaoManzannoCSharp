using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogicaDeProgramacaoManzannoCSharp.ExerciciosPag25_26
{
    internal class Ex09QuadradoDiferenca
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de A: ");
            double valorA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor de B: ");
            double valorB = Convert.ToDouble(Console.ReadLine());

            double formula1 = Math.Pow((valorA - valorB), 2);
            double formula2 = Math.Pow(valorA, 2) - 2 * (valorA * valorB) + Math.Pow(valorB, 2);

            Console.WriteLine($"Fórmula 1 = {formula1}" +
                $"\nFórmula 2 = {formula2}");
        }
    }
}
