using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogicaDeProgramacaoManzannoCSharp.ExerciciosPag46_47
{
    internal class ExWhileE
    {
        public static void Main(string[] args)
        {
            int contador = 1;
            int acumuladora = 1;
            int expoente = 3;

            while (contador < 16)
            {
                acumuladora *= expoente;
                Console.WriteLine($"A quantidade de novos usuários são de {acumuladora} do {contador}° usuario.");
                contador++; 
            }
        }
    }
}
