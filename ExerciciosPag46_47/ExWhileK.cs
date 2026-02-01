using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogicaDeProgramacaoManzannoCSharp.ExerciciosPag46_47
{
    internal class ExWhileK
    {
        static void respostaValidacao(int respost)
        {
            if (respost != 1 && respost != 2)
            {
                throw new Exception(
                    "Resposta invalída! (suas opções são 1 para sim e 2 para não)."
                );
            }
        }

        public static void Main(string[] args)
        {
            try
            {
                int resposta = 1;
                double areaTotal = 0;

                while (resposta == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Digite o nome do cômodo: ");
                    string nomeComodo = Console.ReadLine();
                    Console.WriteLine("Digite a lagura do cômodo: ");
                    double larguraComodo = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o comprimento do cômodo: ");
                    double comprimentoComodo = Convert.ToDouble(Console.ReadLine());

                    double areaComodo = larguraComodo * comprimentoComodo;
                    areaTotal += areaComodo;

                    Console.Clear();
                    Console.WriteLine(
                        $"Nome do cômodo: {nomeComodo}" + $"\nA aŕea do cômodo: {areaComodo}m²"
                    );

                    Console.WriteLine("Deseja calcular outro cômodo? [1]SIM [2]NÃO");
                    resposta = Convert.ToInt16(Console.ReadLine());
                    respostaValidacao(resposta);
                }
                Console.Clear();
                Console.WriteLine($"A área total da casa é {areaTotal}m²");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
