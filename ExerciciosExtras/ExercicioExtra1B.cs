using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogicaDeProgramacaoManzannoCSharp.ExerciciosExtras
{
    internal class ExercicioExtra1B
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=====| Holerite |=====" +
                "\nDigite o valor do salário atual: ");
            double salarioAtual = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor do reajuste em porcentagem: ");
            double reajustePercentual = Convert.ToDouble(Console.ReadLine());

            double salarioNovo = salarioAtual + (salarioAtual * (reajustePercentual / 100));
            double descontoInns = salarioNovo * 0.11;
            double decontIr = salarioNovo * 0.05;
            double salarioFinal = salarioNovo - (descontoInns + decontIr);

            Console.WriteLine($"O seu novo salário: {salarioNovo.ToString("C2")}" +
                $"\nTotal de Descontos: {(descontoInns + decontIr).ToString("C2")}" +
                $"\nSalário Liquido: {salarioFinal.ToString("C2")}");


        }
    }
}
