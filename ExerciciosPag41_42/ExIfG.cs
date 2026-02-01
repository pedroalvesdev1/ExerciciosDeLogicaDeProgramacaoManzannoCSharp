using System;

namespace ExerciciosDeLogicaDeProgramacaoManzannoCSharp.ExerciciosPag41_42
{
    internal class ExIfG
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade do produto: ");
            int quantProduto = Convert.ToInt32(Console.ReadLine());

            if (quantProduto % 2 == 0 && quantProduto % 3 == 0)
            {
                Console.WriteLine("Lote compatível com empacotamento padrão");
            }
            else
            {
                Console.WriteLine($"Necessário redividir o lote. Valor informado: {quantProduto}");
            }
        }
    }
}
