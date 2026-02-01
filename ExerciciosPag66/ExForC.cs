using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogicaDeProgramacaoManzannoCSharp.ExerciciosPag66
{
    internal class ExForC
    {
        public static void Main(string[] args)
        {
            int valorAcumulado = 0;
            for (int contador = 1; contador < 101; contador++)
            {
                valorAcumulado += contador;
            }
            Console.Clear();
            Console.WriteLine($"AO final dos 100 dias o valor será {valorAcumulado:C2}");
        }
    }
}
