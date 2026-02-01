using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogicaDeProgramacaoManzannoCSharp.ExerciciosPag25_26
{
    internal class Ex03VolumeAreaTotalCilindro
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("----------| Cálculo Cilíndro |----------" +
                "\nDigite o volume da lata: ");
            double raioLata = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor da altura da lata: ");
            double alturaLata = Convert.ToDouble(Console.ReadLine());

            double volumeLata = Math.PI * Math.Pow(raioLata, 2) * alturaLata;
            double areaTotal = 2 * Math.PI * raioLata * (raioLata *  alturaLata);

            Console.WriteLine($"Sobre este cilíndro: " +
                $"\nÁrea total = {areaTotal.ToString("F2")}" +
                $"\nVolume = {volumeLata.ToString("F2")}");
        }
    }
}
