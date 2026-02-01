using System;
using System.Diagnostics.Contracts;

namespace ExerciciosDeLogicaDeProgramacaoManzannoCSharp.ExerciciosPag46_47
{
    internal class ExWhileA
    {
        public static void Main(string[] args)
        {
            int contador = 1;

            Console.WriteLine("Digite o valor unitário do produto: ");
            decimal valorUnitario = Convert.ToDecimal(Console.ReadLine());

            while (contador < 11)
            {
                decimal totalValor = valorUnitario * contador;
                Console.WriteLine(
                    $"Ao comprar {contador} peças sai por {totalValor.ToString("C2")}"
                );
                contador++;
            }
        }
    }
}
