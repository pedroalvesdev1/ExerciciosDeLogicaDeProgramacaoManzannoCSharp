using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogicaDeProgramacaoManzannoCSharp.ExerciciosPag25_26
{
    internal class Ex02FahrenheitParaCelsius
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Convesor Fahrenheit Para Celsius" +
                "\nDigite o valor da temperatura em graus Fahrenheit:");
            double grausFahrenheit = Convert.ToDouble(Console.ReadLine());

            double grausCelsius = (grausFahrenheit - 32) / 1.8;

            Console.WriteLine($"O valor da temperatura em Graus Celsius é {grausCelsius}°C.");
        }
    }
}
