using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogicaDeProgramacaoManzannoCSharp.ExerciciosPag66
{
    internal class ExForK
    {
        public static void Main(string[] args)
        {
            for (int contador = 1; contador <= 15; contador++)
            {
                if (contador % 2 != 0)
                {
                    int fatorial = 1;

                    for (int contador2 = 1; contador2 <= contador; contador2++)
                    {
                        fatorial *= contador2;
                    }

                    Console.WriteLine($"O fatorial de {contador} é {fatorial}");
                }
            }
        }
    }
}
