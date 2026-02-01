using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogicaDeProgramacaoManzannoCSharp.ExerciciosPag50
{
    internal class ExDoWhileD
    {
        public static void Main(string[] args)
        {
            int contador = 0;
            double acumuladora = 1;
            do
            {
                double consumo = acumuladora * 2;
                acumuladora = consumo;

                Console.WriteLine($"Consumo está em {acumuladora}MB");
                contador++;
            } while (contador < 65);
        }
    }
}
