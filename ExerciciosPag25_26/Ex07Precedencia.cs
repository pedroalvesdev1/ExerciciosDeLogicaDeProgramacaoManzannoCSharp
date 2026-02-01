using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogicaDeProgramacaoManzannoCSharp.ExerciciosPag25_26
{
    internal class Ex07Precedencia
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de A :");
            int valorA = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Digite o valor de B :");
            int valorB = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Digite o valor de C :");
            int valorC = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Digite o valor de D :");
            int valorD = Convert.ToInt16(Console.ReadLine());

            int resultado1 = (valorA + valorB) * (valorC + valorD);
            int resultado2 = valorA + valorB * valorC + valorD;

            Console.WriteLine($"Resultado 1: (A + B) * (C + D) \nValor = {resultado1}" +
                $"\nResultado 2: A + B * C + D \nValor = {resultado2}");
        }
    }
}