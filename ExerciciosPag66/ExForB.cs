using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogicaDeProgramacaoManzannoCSharp.ExerciciosPag66
{
    internal class ExForB
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor unitário do produto: ");
            decimal valorUnitario = Convert.ToDecimal(Console.ReadLine());
            for (int contador = 1; contador < 11; contador++)
            {
                decimal multiplicador = valorUnitario * contador;
                Console.WriteLine($"Lote de {contador}: \t{multiplicador:C2}");
            }
        }
    }
}
