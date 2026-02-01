using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogicaDeProgramacaoManzannoCSharp.ExerciciosPag41_42
{
    internal class ExIfH
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do 1° servidor: ");
            double temperatura1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor do 2° servidor: ");
            double temperatura2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor do 3° servidor: ");
            double temperatura3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor do 4° servidor: ");
            double temperatura4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor do 5° servidor: ");
            double temperatura5 = Convert.ToDouble(Console.ReadLine());

            double maiorTemperatura = 0;
            double menorTemperatura = temperatura1;

            if (
                temperatura1 > temperatura2
                && temperatura1 > temperatura3
                && temperatura1 > temperatura4
                && temperatura1 > temperatura5
            )
            {
                maiorTemperatura = temperatura1;
            }
            else if (
                temperatura2 > temperatura1
                && temperatura2 > temperatura3
                && temperatura2 > temperatura4
                && temperatura2 > temperatura5
            )
            {
                maiorTemperatura = temperatura2;
            }
            else if (
                temperatura3 > temperatura1
                && temperatura3 > temperatura2
                && temperatura3 > temperatura4
                && temperatura3 > temperatura5
            )
            {
                maiorTemperatura = temperatura3;
            }
            else if (
                temperatura4 > temperatura1
                && temperatura4 > temperatura2
                && temperatura4 > temperatura3
                && temperatura4 > temperatura5
            )
            {
                maiorTemperatura = temperatura4;
            }
            else if (
                temperatura5 > temperatura1
                && temperatura5 > temperatura2
                && temperatura5 > temperatura3
                && temperatura5 > temperatura4
            )
            {
                maiorTemperatura = temperatura5;
            }

            if (
                temperatura1 < temperatura2
                && temperatura1 < temperatura3
                && temperatura1 < temperatura4
                && temperatura1 < temperatura5
            )
            {
                menorTemperatura = temperatura1;
            }
            else if (
                temperatura2 < temperatura1
                && temperatura2 < temperatura3
                && temperatura2 < temperatura4
                && temperatura2 < temperatura5
            )
            {
                menorTemperatura = temperatura2;
            }
            else if (
                temperatura3 < temperatura1
                && temperatura3 < temperatura2
                && temperatura3 < temperatura4
                && temperatura3 < temperatura5
            )
            {
                menorTemperatura = temperatura3;
            }
            else if (
                temperatura4 < temperatura1
                && temperatura4 < temperatura2
                && temperatura4 < temperatura3
                && temperatura4 < temperatura5
            )
            {
                menorTemperatura = temperatura4;
            }
            else if (
                temperatura5 < temperatura1
                && temperatura5 < temperatura2
                && temperatura5 < temperatura3
                && temperatura5 < temperatura4
            )
            {
                menorTemperatura = temperatura5;
            }

            Console.Clear();
            Console.WriteLine($"Risco de superaquecimento: {maiorTemperatura}°C");
            Console.WriteLine($"Ocioso: {menorTemperatura}°C");
        }
    }
}
