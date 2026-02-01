using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogicaDeProgramacaoManzannoCSharp.ExerciciosPag25_26
{
    internal class Ex10CambioIOF
    {
        //contação (07/12/25)
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite a contação do dolár hoje: ");
            double dolarCotacao = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite reais você tem em mãos: ");
            double quantReais = Convert.ToDouble(Console.ReadLine());

            double quantDolar = quantReais / dolarCotacao;

            double impostoIOF = quantDolar - (quantDolar * 0.011);

            Console.WriteLine($"Depois da aplicação impostos você tem US$ {impostoIOF:F2}");
        }
    }
}