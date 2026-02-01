using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogicaDeProgramacaoManzannoCSharp.ExerciciosPag46_47
{
    internal class ExWhileD
    {
        public static void Main(string[] args)
        {
            int contador = 0;

            while (contador < 21)
            {
                if (contador % 2 != 0)
                {
                    Console.WriteLine($"Está disponível o {contador}° horário");
                }
                contador++;
            }
        }
    }
}
