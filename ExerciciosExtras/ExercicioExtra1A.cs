using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogicaDeProgramacaoManzannoCSharp.ExerciciosExtras
{
    internal class ExercicioExtra1A
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de A: ");
            int valorA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor de B: ");
            int valorB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor de C: ");
            int valorC = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor de D: ");
            int valorD = Convert.ToInt32(Console.ReadLine());

            int produtosExtremos = valorA * valorD;
            int somaMeio = valorB + valorC;

            int diferencasEntreResultados = produtosExtremos - somaMeio;

            Console.WriteLine($"O código de segurança para [{valorA}, {valorB}, {valorC}, {valorD}] é: {diferencasEntreResultados}");
        }
    }
}
