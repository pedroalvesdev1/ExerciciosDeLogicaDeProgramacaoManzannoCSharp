using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogicaDeProgramacaoManzannoCSharp.ExerciciosPag66
{
    internal class ExForE
    {
        public static void Main(string[] args)
        {
            for (int contador = 0; contador <= 20; contador++)
            {
                if (contador % 2 != 0)
                {
                    Console.WriteLine($"Alerta: Código de Erro {contador} detectado");
                }
            }
        }
    }
}
