using System;
using System.Globalization;
using System.Text;
using System.Linq;

namespace NonoExercicio
{
    public class OrganizandoStringsPorTamanho
    {
        static void Main(string[] args)
        {

            int numeroCasos = int.Parse(Console.ReadLine());
            string[] arrayLista = new string[numeroCasos];
            int contador = numeroCasos;
            

            for (int i = 0; i < numeroCasos; i++)
            {
                var frase = Console.ReadLine().Split(' ');

                var fraseDecrescente = frase.OrderByDescending(x => x.Length);

                foreach (var palavraDaFraseDecrescente in fraseDecrescente)
                {
                    Console.Write($"{palavraDaFraseDecrescente}");  
                }
                Console.Write("\n"); 
            }

        }
    }

}
