using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogicaDeProgramacaoManzannoCSharp.ExerciciosPag50
{
    internal class ExDoWhileJ
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o total de produtos: ");
            int totalProdutos = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Digite a capacidade da caixa: ");
            int capacidadeCaixa = Convert.ToInt16(Console.ReadLine());

            int quociente = 0;

            if (capacidadeCaixa == 0)
            {
                Console.Clear();
                Console.WriteLine("ERRO: não é possível dividir um número por 0.");
            }
            else
            {
                do
                {
                    totalProdutos -= capacidadeCaixa;
                    quociente++;
                } while (totalProdutos >= capacidadeCaixa);
            }
            Console.Clear();
            Console.WriteLine($"Caixas cheias (Quociente): {quociente}");
            Console.WriteLine($"Produtos que sobraram (Resto): {totalProdutos}");
        }
    }
}
