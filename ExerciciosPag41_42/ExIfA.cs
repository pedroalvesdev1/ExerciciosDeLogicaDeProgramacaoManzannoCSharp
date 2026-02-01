using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogicaDeProgramacaoManzannoCSharp.ExerciciosPag41_42
{
    internal class ExIfA
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o pre�o de abertura: ");
            decimal precoAbertura = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite o pre�o de abertura: ");
            decimal precoFechamento = Convert.ToDecimal(Console.ReadLine());

            decimal variacaoAbsoluta = precoFechamento - precoAbertura;

            if (precoFechamento > variacaoAbsoluta)
            {
                Console.WriteLine($"Teve um lucro de {variacaoAbsoluta.ToString("C2")}");
            }
            else
            {
                Console.WriteLine($"Teve um preju�zo de {variacaoAbsoluta.ToString("C2")}");
            }
        }
    }
}
