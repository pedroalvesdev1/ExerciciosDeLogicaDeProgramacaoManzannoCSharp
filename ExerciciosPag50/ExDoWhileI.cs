using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogicaDeProgramacaoManzannoCSharp.ExerciciosPag50
{
    internal class ExDoWhileI
    {
        public static void Main(string[] args)
        {
            double temperaturaServidor = 0;
            double maiorTemperatura = temperaturaServidor;
            double menorTemperatura = double.MaxValue;

            do
            {
                Console.Clear();
                Console.WriteLine("Digite o valor da temperatura: ");
                temperaturaServidor = Convert.ToDouble(Console.ReadLine());
                if (temperaturaServidor > maiorTemperatura)
                {
                    maiorTemperatura = temperaturaServidor;
                }
                else if (temperaturaServidor < menorTemperatura && temperaturaServidor > 0)
                {
                    menorTemperatura = temperaturaServidor;
                }
            } while (temperaturaServidor > 0);

            Console.Clear();
            Console.WriteLine(
                $"A maior temperatura registrada foi {maiorTemperatura}. \nA menor temperatura registrada foi {menorTemperatura}."
            );
        }
    }
}
