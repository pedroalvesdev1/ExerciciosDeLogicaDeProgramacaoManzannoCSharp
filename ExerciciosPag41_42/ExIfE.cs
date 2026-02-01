using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogicaDeProgramacaoManzannoCSharp.ExerciciosPag41_42
{
    internal class ExIfE
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de A: ");
            double valorA = Convert.ToDouble(Console.ReadLine());

            if (valorA == 0)
            {
                Console.WriteLine(
                    "Erro: O valor de A não pode ser zero (não é equação de 2º grau)."
                );
                return;
            }

            Console.WriteLine("Digite o valor de B: ");
            double valorB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor de C: ");
            double valorC = Convert.ToDouble(Console.ReadLine());

            double delta = Math.Pow(valorB, 2) - 4 * (valorA * valorC);

            if (delta < 0)
            {
                Console.WriteLine($"Erro: Dados inconsistentes (sem impacto real)");
            }
            else
            {
                if (valorA != 0)
                {
                    double tempo1 = (-valorB + Math.Sqrt(delta)) / (2 * valorA);
                    double tempo2 = (-valorB - Math.Sqrt(delta)) / (2 * valorA);

                    if (tempo1 >= 0)
                    {
                        Console.WriteLine($"O tempo de lançamento 1 é {Math.Abs(tempo1)}");
                    }

                    if (tempo2 >= 0)
                    {
                        Console.WriteLine($"O tempo de impacto 2 é {tempo2}");
                    }
                }
                else
                {
                    Console.WriteLine("Não possilve dividir um númwro por zero.");
                }
            }
        }
    }
}
