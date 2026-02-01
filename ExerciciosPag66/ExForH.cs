using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogicaDeProgramacaoManzannoCSharp.ExerciciosPag66
{
    internal class ExForH
    {
        public static void Main(string[] args)
        {
            //taxa base e base da potência
            // tempo em anos é o expoente

            int resultado = 1;

            Console.WriteLine("Digite o valor da taxa base:");
            int taxaBase = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Digite o tempo em anos :");
            int tempoAnos = Convert.ToInt16(Console.ReadLine());

            for (int contador = 1; contador <= tempoAnos; contador++)
            {
                resultado *= taxaBase;
            }

            Console.WriteLine(resultado);
        }
    }
}
