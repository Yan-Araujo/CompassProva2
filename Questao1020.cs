using System;
namespace SextoExercicio
{
    public class ConversãoDiasParaMesesEAnos
    {
        static void Main(string[] args)
        {
            int dias = int.Parse(Console.ReadLine());

            int anos = dias / 365;
            int restoDeTempoAnos = dias % 365;

            int meses = restoDeTempoAnos / 30;

            dias = restoDeTempoAnos % 30;

            Console.WriteLine($"{anos} ano(s)");
            Console.WriteLine($"{meses} mes(es)");
            Console.WriteLine($"{dias} dia(s)");

        }
    }

}