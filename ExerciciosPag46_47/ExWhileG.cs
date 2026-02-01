using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogicaDeProgramacaoManzannoCSharp.ExerciciosPag46_47
{
    internal class ExWhileG
    {
        public static void Main(string[] args)
        {
            int contador = 0;
            int anterior = 0;
            int atual = 1;
            int proximo = 0;

            while (contador < 25)
            {
                Console.WriteLine(anterior);
                proximo = atual + anterior;
                anterior = atual;
                atual = proximo;
                contador++;
            }
        }
    }
}
