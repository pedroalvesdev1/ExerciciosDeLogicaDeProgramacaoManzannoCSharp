using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogicaDeProgramacaoManzannoCSharp.ExerciciosExtras
{
    internal class ExercicioExtra1C
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("-----| Analista Político |-----" +
                "\nDigite o total de votos do candidato A: ");
            int votosCanditatoA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o total de votos do candidato B: ");
            int votosCanditatoB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o total de votos do candidato C: ");
            int votosCanditatoC = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o total de votos em branco: ");
            int votosEmBranco = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o total de votos nulos: ");
            int votosNulos = Convert.ToInt32(Console.ReadLine());

            int totalEleitores = votosCanditatoA + votosCanditatoB + votosCanditatoC + votosEmBranco + votosNulos;
            int votosValidosTotal = votosCanditatoA + votosCanditatoB + votosCanditatoC;
            double percentualNulos = (double)votosNulos / totalEleitores * 100 ;
            double percentualBranco = (double)votosEmBranco / totalEleitores* 100 ;

            double percentualCandidatoA = (double)votosCanditatoA / votosValidosTotal * 100;
            double percentualCandidatoB = (double)votosCanditatoB / votosValidosTotal * 100;
            double percentualCandidatoC = (double)votosCanditatoC / votosValidosTotal * 100;



            Console.Clear();

            Console.WriteLine($"\n=== RESULTADO DA APURAÇÃO ===" +
                $"\nTotal de Eleitores: {totalEleitores}" +
                $"\nVotos Válidos: {votosValidosTotal}" +
                "\n-----------------------------" +
                $"\nNulos: {percentualNulos.ToString("F2")}% do total" +
                $"\nBrancos: {percentualBranco.ToString("F2")}% do total" +
                "\n-----------------------------" +
                $"\nCandidato A: {percentualCandidatoA.ToString("F2")}% dos válidos" +
                $"\nCandidato B: {percentualCandidatoB.ToString("F2")}% dos válidos" +
                $"\nCandidato C: {percentualCandidatoC.ToString("F2")}% dos válidos");

        }
    }
}
