using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogicaDeProgramacaoManzannoCSharp.ExerciciosPag46_47
{
    internal class ExWhileL
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor da cotação: ");
            double valorBitcoin = Convert.ToDouble(Console.ReadLine());

            double maior = valorBitcoin;
            double menor = valorBitcoin;

            while (valorBitcoin > -1)
            {
                Console.WriteLine("Digite o valor da cotação: ");
                valorBitcoin = Convert.ToDouble(Console.ReadLine());

                if (valorBitcoin > maior)
                {
                    maior = valorBitcoin;
                }
                else if (valorBitcoin < menor && valorBitcoin > -1)
                {
                    menor = valorBitcoin;
                }
            }

            Console.WriteLine($"Maior número: {maior} \nMenor número: {menor}");
        }
    }
}
