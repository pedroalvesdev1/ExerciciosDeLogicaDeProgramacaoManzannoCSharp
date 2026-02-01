using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogicaDeProgramacaoManzannoCSharp.ExerciciosPag41_42
{
    internal class ExIfB
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu quilometro de partida (ex: estou no 10km): ");
            float kmPartida = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite o seu quilometro de chegada (ex: quero ir pro 15km): ");
            float kmChegada = Convert.ToSingle(Console.ReadLine());

            float distancia = Math.Abs(kmChegada - kmPartida);

            Console.Clear();
            Console.WriteLine($"\nVoc� ir� percorrer {distancia}Km para chegar ao seu destino");
        }
    }
}
