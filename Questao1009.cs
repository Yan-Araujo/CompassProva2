using System;
namespace PrimeiroExercicio
{
    public class Salario
    {
        static void Main(string[] args)
        {

            double salarioTotal;
            double comissao;
            string nome = Console.ReadLine();
            double salario = double.Parse(Console.ReadLine());
            double totalVendas = double.Parse(Console.ReadLine());

            comissao = (totalVendas * 0.15);
            salarioTotal = (salario + comissao);

            Console.WriteLine($"TOTAL = R$ {salarioTotal.ToString("F2")}");


        }
    }

}