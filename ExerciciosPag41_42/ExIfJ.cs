using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogicaDeProgramacaoManzannoCSharp.ExerciciosPag41_42
{
    internal class ExIfJ
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite sua nota para o atendimento (dê 1 á 10): ");
            int nota = Convert.ToInt16(Console.ReadLine());

            if (nota < 1 || nota > 10)
            {
                Console.WriteLine("Erro: Nota Inválida");
            }
            else if (nota > 6 && nota < 9)
            {
                Console.WriteLine("Cliente Neutro");
            }
            else if (nota > 0.9 && nota < 7)
            {
                Console.WriteLine("Cliente Detrator");
            }
            else if (nota > 8 && nota < 10)
            {
                Console.WriteLine("Cliente Promotor");
            }
        }
    }
}
