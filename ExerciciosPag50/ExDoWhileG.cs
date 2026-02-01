using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogicaDeProgramacaoManzannoCSharp.ExerciciosPag50
{
    internal class ExDoWhileG
    {
        public static void Main(string[] args)
        {
            int contador = 1;
            do
            {
                if (contador % 2 != 0)
                {
                    int auxiliar = contador;
                    int chaveAleatoria = 1;

                    do
                    {
                        chaveAleatoria *= auxiliar;
                        auxiliar--;
                    } while (auxiliar > 1);

                    Console.WriteLine($"Chave aleatória número {contador}: {chaveAleatoria}.");
                }
                contador++;
            } while (contador < 11);
        }
    }
}
