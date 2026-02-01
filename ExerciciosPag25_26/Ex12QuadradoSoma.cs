using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogicaDeProgramacaoManzannoCSharp.ExerciciosPag25_26
{
    internal class Ex12QuadradoSoma
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de A: ");
            double valorA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor de B: ");
            double valorB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor de C: ");
            double valorC = Convert.ToDouble(Console.ReadLine());

            double resultado = Math.Pow((valorA + valorB + valorC), 2);
            double diferenca = 1000 - resultado;

            if (resultado > 1000)
            {
                Console.WriteLine($"Resultado = {resultado}" +
                    $"\nNúmero passou de 1000 " +
                    $"\nValor de diferença = {diferenca}");
            }
            else
            {
                Console.WriteLine($"Resultado = {resultado} " +
                    $"\nNúmero menor que 1000 " +
                    $"\nValor de diferença = {diferenca}");
            }
        }
    }
}
