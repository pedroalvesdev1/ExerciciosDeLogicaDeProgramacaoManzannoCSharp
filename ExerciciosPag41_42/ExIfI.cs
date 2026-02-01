using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogicaDeProgramacaoManzannoCSharp.ExerciciosPag41_42
{
    internal class ExIfI
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o ultimo número da placa: ");
            int numeroPlaca = Convert.ToInt16(Console.ReadLine());

            if (numeroPlaca % 2 == 0)
            {
                Console.WriteLine("Acesso permitido para Dias Pares");
            }
            else
            {
                Console.WriteLine("Acesso permitido para Dias Ímpares");
            }
        }
    }
}
