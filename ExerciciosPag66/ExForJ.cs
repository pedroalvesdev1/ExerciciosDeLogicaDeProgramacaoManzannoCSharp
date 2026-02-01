using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogicaDeProgramacaoManzannoCSharp.ExerciciosPag66
{
    internal class ExForJ
    {
        public static void Main(string[] args)
        {
            for (int grausCelsius = 10; grausCelsius <= 100; grausCelsius += 10)
            {
                double grausFahrenheit = (grausCelsius * 1.8) + 32;
                Console.WriteLine($"Temp: {grausCelsius}ºC equivale a {grausFahrenheit}ºF");
            }
        }
    }
}
