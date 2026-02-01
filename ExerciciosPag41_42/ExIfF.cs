using System;

namespace ExerciciosDeLogicaDeProgramacaoManzannoCSharp.ExerciciosPag41_42
{
    internal class ExIfF
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Digite o valor do 1°  produto: ");
            decimal produto1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite o valor do 2°  produto: ");
            decimal produto2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite o valor do 3°  produto: ");
            decimal produto3 = Convert.ToDecimal(Console.ReadLine());

            decimal menor;
            decimal meio;
            decimal maior;

            if (produto1 < produto2 && produto2 < produto3)
            {
                menor = produto1;
                meio = produto2;
                maior = produto3;
            }
            else if (produto1 < produto3 && produto3 < produto2)
            {
                menor = produto1;
                meio = produto3;
                maior = produto2;
            }
            else if (produto2 < produto1 && produto1 < produto3)
            {
                menor = produto2;
                meio = produto1;
                maior = produto3;
            }
            else if (produto2 < produto3 && produto3 < produto1)
            {
                menor = produto2;
                meio = produto3;
                maior = produto1;
            }
            else if (produto3 < produto1 && produto1 < produto2)
            {
                menor = produto3;
                meio = produto1;
                maior = produto2;
            }
            else
            {
                menor = produto3;
                meio = produto2;
                maior = produto1;
            }

            Console.Clear();
            Console.WriteLine(
                $"\nA 1° melhor ofeta é de {menor.ToString("C2")}"
                    + $"\nA 2° melhor ofeta é de{meio.ToString("C2")}"
                    + $"\nA 3° melhor oferta é de{maior.ToString("C2")}"
            );
        }
    }
}
