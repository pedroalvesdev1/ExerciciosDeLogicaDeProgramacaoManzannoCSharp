using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogicaDeProgramacaoManzannoCSharp.ExerciciosPag50
{
    internal class ExDoWhileF
    {
        public static void Main(string[] args)
        {
            double valorescompras = 0;
            double totalCompras = 0;
            int quantCompras = 0;
            do
            {
                Console.WriteLine("Digite o valor da compra: ");
                valorescompras = Convert.ToDouble(Console.ReadLine());

                if (valorescompras > 0)
                {
                    totalCompras += valorescompras;
                    quantCompras++;
                }
            } while (valorescompras > 0);

            double ticketMedio = totalCompras / quantCompras;
            Console.Clear();
            Console.WriteLine(
                "===========| Faturamento do dia |==========="
                    + $"\n\tFaturamento total: {totalCompras.ToString("C2")}"
                    + $"\n\tQuantidade de compras: {quantCompras}"
                    + $"\n\tTicket Medio: {ticketMedio:f2}"
            );
        }
    }
}
