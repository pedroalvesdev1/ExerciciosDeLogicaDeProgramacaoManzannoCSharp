using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogicaDeProgramacaoManzannoCSharp.ExerciciosPag66
{
    internal class ExForI
    {
        public static void Main(string[] args)
        {
            int fibonnaci = 0;
            int antecessor = 0;
            int sucessor = 1;
            Console.WriteLine(sucessor);
            for (int contador = 1; contador <= 15; contador++)
            {
                fibonnaci = antecessor + sucessor;
                antecessor = sucessor;
                sucessor = fibonnaci;
                Console.WriteLine(fibonnaci);
            }
        }
    }
}
