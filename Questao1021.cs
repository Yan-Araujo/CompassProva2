using System;
using System.Globalization;
namespace SetimoExercicio
{
    public class DivisaoDeValorUsandoNotasEMoedas
    {
        static void Main(string[] args)
        {
            
            decimal valor = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            int quantidadeNotas100;
            int quantidadeNotas50;
            int quantidadeNotas20;
            int quantidadeNotas10;
            int quantidadeNotas5;
            int quantidadeNotas2;
            int quantidadeMoedas1Real;
            int quantidadeMoedas50Centavo;
            int quantidadeMoedas25Centavo;
            int quantidadeMoedas10Centavo;
            int quantidadeMoedas5Centavo;
            int quantidadeMoedas1Centavo;
            
            quantidadeNotas100 = (int)((valor - (valor % 100))/100);
            valor = valor % 100;

            quantidadeNotas50 = (int)((valor - (valor % 50)) / 50);
            valor = valor % 50;

            quantidadeNotas20 = (int)((valor - (valor % 20)) / 20);
            valor = valor % 20;

            quantidadeNotas10 = (int)((valor - (valor % 10)) / 10);
            valor = valor % 10;

            quantidadeNotas5 = (int)((valor - (valor % 5)) / 5);
            valor = valor % 5;

            quantidadeNotas2 = (int)((valor - (valor % 2)) / 2);
            valor = valor % 2;

            quantidadeMoedas1Real = (int)((valor - (valor % 1)) / 1);
            valor = valor % 1;

            quantidadeMoedas50Centavo = (int)((valor - (valor % 0.5m)) / 0.5m);
            valor = valor % 0.5m;

            quantidadeMoedas25Centavo = (int)((valor - (valor % 0.25m)) / 0.25m);
            valor = valor % 0.25m;

            quantidadeMoedas10Centavo = (int)((valor - (valor % 0.1m)) / 0.1m);
            valor = valor % 0.1m;

            quantidadeMoedas5Centavo = (int)((valor - (valor % 0.05m)) / 0.05m);
            valor = valor % 0.05m;

            quantidadeMoedas1Centavo = (int)Math.Round((valor - (valor % 0.01m)) / 0.01m);


            Console.WriteLine("NOTAS:");
            Console.WriteLine($"{quantidadeNotas100} nota(s) de R$ 100.00");
            Console.WriteLine($"{quantidadeNotas50} nota(s) de R$ 50.00");
            Console.WriteLine($"{quantidadeNotas20} nota(s) de R$ 20.00");
            Console.WriteLine($"{quantidadeNotas10} nota(s) de R$ 10.00");
            Console.WriteLine($"{quantidadeNotas5} nota(s) de R$ 5.00");
            Console.WriteLine($"{quantidadeNotas2} nota(s) de R$ 2.00");
            Console.WriteLine("MOEDAS:");
            Console.WriteLine($"{quantidadeMoedas1Real} moeda(s) de R$ 1.00");
            Console.WriteLine($"{quantidadeMoedas50Centavo} moeda(s) de R$ 0.50");
            Console.WriteLine($"{quantidadeMoedas25Centavo} moeda(s) de R$ 0.25");
            Console.WriteLine($"{quantidadeMoedas10Centavo} moeda(s) de R$ 0.10");
            Console.WriteLine($"{quantidadeMoedas5Centavo} moeda(s) de R$ 0.05");
            Console.WriteLine($"{quantidadeMoedas1Centavo} moeda(s) de R$ 0.01");

        }
    }
    
}
