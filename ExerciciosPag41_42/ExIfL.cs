using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogicaDeProgramacaoManzannoCSharp.ExerciciosPag41_42
{
    internal class ExIfL
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do cliente: ");
            string nomeCliente = Console.ReadLine();
            Console.WriteLine(
                "Digite o código do perfil de compra (1 para Moda Masculina, 2 para Moda Feminina): "
            );
            int perfilCliente = Convert.ToInt16(Console.ReadLine());

            if (perfilCliente == 1)
            {
                Console.WriteLine($"Olá Sr. {nomeCliente}, confira nossa coleção de ternos!");
            }
            else if (perfilCliente == 2)
            {
                Console.WriteLine($"Olá Sra. {nomeCliente}, venha ver os novos vestidos de verão!");
            }
            else
            {
                Console.WriteLine($"Olá {nomeCliente}, confira nossas ofertas gerais!");
            }
        }
    }
}
