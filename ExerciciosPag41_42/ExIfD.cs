using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogicaDeProgramacaoManzannoCSharp.ExerciciosPag41_42
{
    internal class ExIfD
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor da pontua��o inicial do lote: ");
            float pontuacaoInicial = Convert.ToSingle(Console.ReadLine());

            if (pontuacaoInicial > 80)
            {
                Console.WriteLine("APROVADO para venda");
            }
            else if (pontuacaoInicial < 80)
            {
                Console.WriteLine("Digite o valor da pontua��o do lote de retrabalho: ");
                float pontuacaoSecundaria = Convert.ToSingle(Console.ReadLine());

                float confirmacao = (pontuacaoInicial + pontuacaoSecundaria) / 2;

                if (confirmacao > 70)
                {
                    Console.WriteLine("APROVADO com Ressalvas");
                }
                else
                {
                    Console.WriteLine("Lote DESCARTADO");
                }
            }
        }
    }
}
