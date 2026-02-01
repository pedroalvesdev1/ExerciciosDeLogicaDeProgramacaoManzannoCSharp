using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogicaDeProgramacaoManzannoCSharp.ExerciciosPag25_26
{
    internal class Ex04GastosViagem
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" Computador de Bordo " +
                "\nDigite o tempo total da viagem em horas: ");
            double horasViagem = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a velocidade média do automóvel: ");
            double velocidadeMedia = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o consumo do seu carro(quantos km ele faz com 1 litro");
            double consumoPorLitro = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o preço do combustivel: ");
            double valorCombustivel = Convert.ToDouble(Console.ReadLine());

            double distanciaPercorrida = horasViagem * velocidadeMedia;
            double consumoViagem = distanciaPercorrida / consumoPorLitro;
            double gastoCombustivel = valorCombustivel * consumoViagem;

            Console.Clear();

            Console.WriteLine($"Você percorreu {distanciaPercorrida}Km " +
                $"\nVocê usou {consumoViagem}l de combustível" +
                $"\nVocê gastou {gastoCombustivel.ToString("C2")}");

        } 
    }
}
