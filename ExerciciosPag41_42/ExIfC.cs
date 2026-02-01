using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogicaDeProgramacaoManzannoCSharp.ExerciciosPag41_42
{
    internal class ExIfC
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do sal�rio bruto: ");
            decimal salarioBruto = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite o valor da parcela do empr�stimo: ");
            decimal valorParcelaEmprestimo = Convert.ToDecimal(Console.ReadLine());

            decimal verificacaoRenda = salarioBruto * (decimal)0.30;

            if (valorParcelaEmprestimo < verificacaoRenda)
            {
                Console.WriteLine("Empr�stimo APROVADO");
            }
            else
            {
                Console.WriteLine("Empr�stimo NEGADO - Renda insuficiente");
            }
        }
    }
}
