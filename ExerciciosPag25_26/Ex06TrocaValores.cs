using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogicaDeProgramacaoManzannoCSharp.ExerciciosPag25_26
{
    /*
        A receba o valor de B.

        B receba o valor de C.

        C receba o valor original de A.
    */

    internal class Ex06TrocaValores
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de A :");
            int valorA = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Digite o valor de B :");
            int valorB = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Digite o valor de C :");
            int valorC = Convert.ToInt16(Console.ReadLine());

            int auxiliar = valorA;
            valorA = valorB;
            valorB = valorC;
            valorC = auxiliar;

            Console.WriteLine($"{valorA}" +
                $"\n{valorB}" +
                $"\n{valorC}");

        }
    }
}