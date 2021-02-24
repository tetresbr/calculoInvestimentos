using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculoInvestimentos
{
    class Program
    {
        static void Main(string[] args)
        {
            double investimento = 0;
            double juros = 0;
            double rendimento = 0;
            double aporte = 0;
            int contador = 1;
            int meses = 0;

            Console.WriteLine("Qual o valor investido?");
            investimento = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qual o aporte mensal?");
            aporte = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qual a taxa de Juros?");
            juros = Convert.ToDouble(Console.ReadLine());
            juros = juros / 100;

            Console.WriteLine("Quantos meses o dinheiro rendera?");
            meses = Convert.ToInt32(Console.ReadLine());
            
            while (contador < meses+1)
            {
                rendimento = investimento * juros;
                investimento += rendimento;
                investimento += aporte;
                Console.WriteLine("Saldo no "+contador+" mês R$ "+investimento);
                contador++;
            }
            Console.ReadLine();
        }
    }
}
