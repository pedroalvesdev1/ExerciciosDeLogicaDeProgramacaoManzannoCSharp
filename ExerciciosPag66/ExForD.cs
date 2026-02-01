using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogicaDeProgramacaoManzannoCSharp.ExerciciosPag66
{
    internal class ExForD
    {
        public static void Main(string[] args)
        {
            int idCrediario = 0;
            for (int contador = 1; contador <= 500; contador++)
            {
                if (contador % 2 == 0)
                {
                    idCrediario += contador;
                }
            }

            Console.WriteLine(
                $"A soma dos identificadores de crédito para auditoria resultou em {idCrediario}"
            );
        }
    }
}
