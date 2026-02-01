using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogicaDeProgramacaoManzannoCSharp.ExerciciosPag50
{
    internal class ExDoWhileH
    {
        public static void Main(string[] args)
        {
            int resposta = 1;
            decimal totalInfraestrutura = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Digite o nome do serviço: ");
                string nomeServico = Console.ReadLine();
                Console.WriteLine($"Digite o custo mensal do {nomeServico.ToUpper()}:");
                decimal custoMensal = Convert.ToDecimal(Console.ReadLine());

                totalInfraestrutura += custoMensal;

                Console.Clear();
                Console.WriteLine(
                    $"Nome do serviço: {nomeServico} \nCusto mensal: {custoMensal.ToString("C2")}"
                );

                Console.WriteLine("Deseja adicionar um novo serviço? [1]SIM [2]NÃO");
                resposta = Convert.ToInt16(Console.ReadLine());
            } while (resposta == 1);

            Console.Clear();
            Console.WriteLine($"Total da infraestrutura: {totalInfraestrutura.ToString("C2")}");
        }
    }
}
