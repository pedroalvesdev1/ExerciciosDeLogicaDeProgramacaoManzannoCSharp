using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogicaDeProgramacaoManzannoCSharp.ExerciciosPag41_42
{
    internal class ExIfK
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade atual no estoque: ");
            int quantEstoque = Convert.ToInt32(Console.ReadLine());

            if (quantEstoque <= 5)
            {
                Console.WriteLine("ATENÇÃO: REPOSIÇÃO IMEDIATA NECESSÁRIA.");
            }
            else
            {
                Console.WriteLine("Estoque Normal.");
            }
        }
    }
}
