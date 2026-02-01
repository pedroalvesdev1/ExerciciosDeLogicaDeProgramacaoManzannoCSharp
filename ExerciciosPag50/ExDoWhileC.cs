using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogicaDeProgramacaoManzannoCSharp.ExerciciosPag50
{
    internal class ExDoWhileC
    {
        public static void Main(string[] args)
        {
            int contador = 1;

            do
            {
                Console.Clear();
                if (contador % 4 == 0)
                {
                    Console.WriteLine($"Peça [{contador}] foi selecionada para teste.");
                }
                contador++;
            } while (contador < 201);
        }
    }
}
