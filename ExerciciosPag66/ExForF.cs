using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogicaDeProgramacaoManzannoCSharp.ExerciciosPag66
{
    internal class ExForF
    {
        public static void Main(string[] args)
        {
            int totalAnoElegivel = 0;
            for (int contador = 1; contador <= 200; contador++)
            {
                if (contador % 4 == 0)
                {
                    Console.WriteLine($"Esse ano {contador} é elegivél para uma auditória.");
                    totalAnoElegivel++;
                }
            }

            Console.WriteLine(
                $"Temos no total {totalAnoElegivel} para agendar auditorias completas."
            );
        }
    }
}
