using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogicaDeProgramacaoManzannoCSharp.ExerciciosPag25_26
{
    internal class Ex01Termometro
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("----------| Termômetro Digital |----------" +
                "\nDigite o valor da temperatura em Graus Celsius: ");

            double grausCelsius = Convert.ToSingle(Console.ReadLine());

            double temperaturaKelvin = grausCelsius + 273.15;
            double temperaturaFahrenheit = ((9 * grausCelsius) + 160) / 5;

            Console.WriteLine($"A temperatura de {grausCelsius}°C corresponde " +
                $"\n{temperaturaKelvin}°K" +
                $"\n{temperaturaFahrenheit}°F");
        }
    }
}