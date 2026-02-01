using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogicaDeProgramacaoManzannoCSharp.ExerciciosPag25_26
{
    internal class Ex11Pitagoras3D
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de A: ");
            double valorA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor de B: ");
            double valorB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor de C: ");
            double valorC= Convert.ToDouble(Console.ReadLine());

            double somaQuadrados = Math.Pow(valorA, 2) + Math.Pow(valorB, 2) + Math.Pow(valorC, 2);
            double diagonalCaixa = Math.Sqrt(somaQuadrados);

            Console.WriteLine($"A soma dos quadrados é {somaQuadrados}" +
                $"\nA diagonal da caixa é {diagonalCaixa}");
        }
    }
}
