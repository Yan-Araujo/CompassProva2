using System;
namespace TerceiroExercicio
{
    public class QualNumeroEMaior
    {
        static void Main(string[] args)
        {


            string[] sequenciaNumeros = Console.ReadLine().Split(' ');

            int primeiroNumero = int.Parse(sequenciaNumeros[0]);
            int segundoNumero = int.Parse(sequenciaNumeros[1]);
            int terceiroNumero = int.Parse(sequenciaNumeros[2]);

            int calculoEntrePrimeirosNumeros = ((primeiroNumero + segundoNumero + Math.Abs(primeiroNumero - segundoNumero))/2);
            int calculoEntreNumerosRestantes = ((calculoEntrePrimeirosNumeros + terceiroNumero + Math.Abs(calculoEntrePrimeirosNumeros - terceiroNumero)) / 2);


            Console.WriteLine($"{calculoEntreNumerosRestantes} eh o maior");

        }
    }

}