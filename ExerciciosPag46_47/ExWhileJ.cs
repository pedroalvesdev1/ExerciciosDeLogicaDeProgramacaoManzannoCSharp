using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogicaDeProgramacaoManzannoCSharp.ExerciciosPag46_47
{
    internal class ExWhileJ
    {
        public static void Main(string[] args)
        {
            int contador = 50;
            int somadora = 0;
            int divisor = 0;

            while (contador < 71)
            {
                if (contador % 2 == 0)
                {
                    somadora += contador;
                }
                contador++;
                divisor++;
            }

            double media = somadora / divisor;

            Console.WriteLine($"A média dos valores é {media}");
        }
    }
}
