using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogicaDeProgramacaoManzannoCSharp.ExerciciosPag66
{
    internal class ExForA
    {
        public static void Main(string[] args)
        {
            for (int contador = 15; contador < 201; contador++)
            {
                int usuario = contador * 1000;
                double custo = Math.Pow(contador, 2);
                Console.WriteLine($"Usuários ativos: {usuario:N0} | Custo projetado: {custo:C2}");
            }
        }
    }
}
