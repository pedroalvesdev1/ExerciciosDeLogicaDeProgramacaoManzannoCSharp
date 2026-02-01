using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogicaDeProgramacaoManzannoCSharp.ExerciciosPag25_26
{
    internal class Ex05CombracaJuros
    {
        public static void Main(string[] args)
        {
            const int valorMulta = 15;
            Console.WriteLine(" O Cobrador Implacável " +
                "\nDigite o valor da prestação:");
            decimal valorPrestacao = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite o valor da taxa de juros diárias: ");
            double jurosDiarios = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite quantos dias está em atarso: ");
            int diasAtraso = Convert.ToInt16(Console.ReadLine());

            decimal valorTotal = valorPrestacao + (valorPrestacao * (decimal)(jurosDiarios / 100) * diasAtraso) + valorMulta;

            Console.WriteLine($"O cliente deve pagar {valorTotal.ToString("C2")}");
        }
    }
}