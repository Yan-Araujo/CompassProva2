using System;
using System.Globalization;
using System.Text;
using System.Linq;

namespace DecimaPrimeiraQuestao
{
    public class ParesEImpares
    {
        static void Main(string[] args)
        {
            int quantidadeTestes = int.Parse(Console.ReadLine());

            int[] arrayNumeros = new int[quantidadeTestes];

            for (int i = 0; i < arrayNumeros.Length; i++)
            {
                arrayNumeros[i] = int.Parse(Console.ReadLine());
            }

            foreach (var numeroParaTestar in arrayNumeros.Where(x => x % 2 == 0).OrderBy(x => x))
            {
                Console.WriteLine(numeroParaTestar);
            }

            foreach (var numeroParaTestar in arrayNumeros.Where(x => x % 2 != 0).OrderByDescending(x => x))
            {
                Console.WriteLine(numeroParaTestar);
            }
        }
    }
}
