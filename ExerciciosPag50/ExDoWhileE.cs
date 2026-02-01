using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogicaDeProgramacaoManzannoCSharp.ExerciciosPag50
{
    internal class ExDoWhileE
    {
        public static void Main(string[] args)
        {
            int caminhao = 1;
            int totalRotas = 0;

            do
            {
                Console.WriteLine(
                    $"Digite a quantidade de pontos de entrega do caminhão {caminhao}: "
                );
                int pontosEntrega = Convert.ToInt32(Console.ReadLine());

                int fatorial = 1;
                int contador = pontosEntrega;

                if (contador > 1)
                {
                    do
                    {
                        fatorial *= contador;
                        contador--;
                    } while (contador > 1);
                }

                Console.WriteLine($"Rotas possíveis para este caminhão: {fatorial}");
                totalRotas += fatorial;

                caminhao++;
            } while (caminhao <= 15);

            Console.WriteLine($"Total de rotas combinadas da frota: {totalRotas}");
        }
    }
}
