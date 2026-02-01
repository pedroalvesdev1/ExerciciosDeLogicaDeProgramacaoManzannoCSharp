using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogicaDeProgramacaoManzannoCSharp.ExerciciosPag46_47
{
    internal class ExWhileH
    {
        public static void Main(string[] args)
        {
            int celsius = 10;
            double fahrenheit = 0;

            while (celsius < 101)
            {
                fahrenheit = (celsius * 9 / 5) + 32;
                Console.WriteLine(
                    $"Temperatura em graus Celsius: {celsius}°C"
                        + $"\t\t\tTemperatura em graus Fahrenheit: {fahrenheit}°F"
                );
                celsius += 10;
            }
        }
    }
}
