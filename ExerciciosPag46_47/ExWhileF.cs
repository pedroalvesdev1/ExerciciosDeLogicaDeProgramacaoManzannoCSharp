using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogicaDeProgramacaoManzannoCSharp.ExerciciosPag46_47
{
    internal class ExWhileF
    {
        public static void Main(string[] args)
        {
            int contador = 1;
            double saldo = 1;

            Console.WriteLine("Digite quantos meses será o rendimento: ");
            int numMeses = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Digite o valor da taxa mês á mês: ");
            double valorTaxa = Convert.ToDouble(Console.ReadLine());

            Console.Clear();
            while (contador <= numMeses)
            {
                saldo *= valorTaxa;
                Console.WriteLine($"Mês {contador}: {saldo.ToString("C2")}");
                contador++;
            }

            Console.WriteLine($"Ao final seu 1 real rendeu {saldo.ToString("C2")}.");
        }
    }
}
