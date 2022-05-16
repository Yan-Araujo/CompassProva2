using System;
namespace QuartoExercicio
{
    public class DivisaoDeValorUsandoNotas
    {
        static void Main(string[] args)
        {
            int valor = int.Parse(Console.ReadLine());
            int valorInicial = valor;

            int quantidadeNotas100;
            int quantidadeNotas50;
            int quantidadeNotas20;
            int quantidadeNotas10;
            int quantidadeNotas5;
            int quantidadeNotas2;
            int quantidadeNotas1;
            
            //1) valor - (valor%100) irá retornar somente o valor exato da centena(Ex: 567 -> 500)
            //e dividir por 100 irá retornar o valor unitário da centena(Ex: 500 -> 5)
            quantidadeNotas100 = ((valor - (valor % 100))/100);

            //2) Aqui atribuimos um novo valor a variável "valor" onde terá como valor o que restou
            //da divisaão anterior
            valor = valor % 100;

            //Iremos repetir os passos 1 e 2 para todas as notas alterando o valor da divisão com resto
            //para combinar com o valor da nota(Ex: nota 50 -> valor = valor % 50)
            quantidadeNotas50 = ((valor - (valor % 50)) / 50);
            valor = valor % 50;

            quantidadeNotas20 = ((valor - (valor % 20)) / 20);
            valor = valor % 20;

            quantidadeNotas10 = ((valor - (valor % 10)) / 10);
            valor = valor % 10;

            quantidadeNotas5 = ((valor - (valor % 5)) / 5);
            valor = valor % 5;

            quantidadeNotas2 = ((valor - (valor % 2)) / 2);
            valor = valor % 2;

            quantidadeNotas1 = ((valor - (valor % 1)) / 1);

            Console.WriteLine(valorInicial);
            Console.WriteLine($"{quantidadeNotas100} nota(s) de R$ 100,00");
            Console.WriteLine($"{quantidadeNotas50} nota(s) de R$ 50,00");
            Console.WriteLine($"{quantidadeNotas20} nota(s) de R$ 20,00");
            Console.WriteLine($"{quantidadeNotas10} nota(s) de R$ 10,00");
            Console.WriteLine($"{quantidadeNotas5} nota(s) de R$ 5,00");
            Console.WriteLine($"{quantidadeNotas2} nota(s) de R$ 2,00");
            Console.WriteLine($"{quantidadeNotas1} nota(s) de R$ 1,00");

        }
    }
    
}