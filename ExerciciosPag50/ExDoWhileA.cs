using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogicaDeProgramacaoManzannoCSharp.ExerciciosPag50
{
    internal class ExDoWhileA
    {
        public static void Main(string[] args)
        {
            int contador = 0;

            Console.WriteLine("Digite valor que será investido: ");
            double dinheiroInvestido = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor da taxa em porcentagem: ");
            double valorTaxa = Convert.ToDouble(Console.ReadLine());

            valorTaxa /= 100;

            do
            {
                dinheiroInvestido += (dinheiroInvestido * valorTaxa);
                contador++;
                if (contador >= 15)
                {
                    Console.WriteLine($"Mês {contador}: {dinheiroInvestido:C2}");
                }
            } while (contador < 201);
        }
    }
}
