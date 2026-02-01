using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogicaDeProgramacaoManzannoCSharp.ExerciciosPag50
{
    internal class ExDoWhileB
    {
        public static void Main(string[] args)
        {
            int contador = 1;
            decimal valorAcumulado = 0;

            do
            {
                if (contador % 2 == 0)
                {
                    const decimal entradaCapital = 100;
                    valorAcumulado += entradaCapital;
                }
                contador++;
            } while (contador < 501);

            Console.WriteLine($"O total de entradas foi de {valorAcumulado.ToString("C2")}");
        }
    }
}
