using System;
namespace SegundoExercicio
{
    public class CalculandoValorCompras
    {
        static void Main(string[] args)
        {
            string[] peca1 = Console.ReadLine().Split(' ');
            int codigoPeca1 = int.Parse(peca1[0]);
            int quantidadePeca1 = int.Parse(peca1[1]);
            double valorPeca1 = double.Parse(peca1[2]);


            string[] peca2 = Console.ReadLine().Split(' ');
            double codigopeca2 = int.Parse(peca2[0]);
            int quantidadePeca2 = int.Parse(peca2[1]);
            double valorPeca2 = double.Parse(peca2[2]);


            double valorTotalPeca1 = (quantidadePeca1 * valorPeca1);
            double valorTotalPeca2 = (quantidadePeca2 * valorPeca2);


            double valorTotalCompras = (valorTotalPeca1 + valorTotalPeca2);


            Console.WriteLine($"VALOR A PAGAR: R$ {valorTotalCompras.ToString("F2")}");

        }
    }

}
