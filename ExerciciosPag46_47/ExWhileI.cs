using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogicaDeProgramacaoManzannoCSharp.ExerciciosPag46_47
{
    internal class ExWhileI
    {
        public static void Main(string[] args)
        {
            int contador = 1;
            double nota = 0;
            double somadora = 0;

            while (contador < 11)
            {
                Console.WriteLine($"Digite o valor da {contador}° : ");
                nota = Convert.ToDouble(Console.ReadLine());
                somadora += nota;
                contador++;
            }

            double media = somadora / 10;
            Console.WriteLine($"A média das nota notas foi de {media}");
        }
    }
}
