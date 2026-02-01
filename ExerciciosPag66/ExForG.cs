using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogicaDeProgramacaoManzannoCSharp.ExerciciosPag66
{
    internal class ExForG
    {
        public static void Main(string[] args)
        {
            const int baseFixa = 3;
            int expoente = 0;
            int resultado = 1;

            for (int contador = 0; contador <= 15; contador++)
            {
                if (expoente == 0)
                {
                    Console.WriteLine($"No nível {contador} será {resultado} cliente");
                }
                else
                {
                    resultado *= baseFixa;
                    Console.WriteLine($"No nível {contador} serão {resultado} clientes");
                }

                expoente++;
            }
        }
    }
}
