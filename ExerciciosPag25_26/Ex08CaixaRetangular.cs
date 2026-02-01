using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogicaDeProgramacaoManzannoCSharp.ExerciciosPag25_26
{
    internal class Ex08CaixaRetangular
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("-----| Volume e capacidade da caixa retangular |-----" +
                "\nDigite o valor da largura: ");
            double largura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor do comprimento: ");
            double comprimento = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor da altura:");
            double altura = Convert.ToDouble(Console.ReadLine());

            double volumeCaixa = (largura * comprimento * altura);
            double capacidadeCaixa = volumeCaixa * 1000;

            Console.Clear();

            Console.WriteLine($"O volume é {volumeCaixa}m³" +
                $"\nCapacidade em litros é {capacidadeCaixa}l");
        }
    }
}