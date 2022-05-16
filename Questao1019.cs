using System;
namespace QuintoExercicio
{
    public class ConversãoDeTempo
    {
        static void Main(string[] args)
        {
            
            int tempoTotalEmSegundos = int.Parse(Console.ReadLine());

            int horas = (tempoTotalEmSegundos / 3600);

            int tempoRestante = (tempoTotalEmSegundos % 3600);

            int minutos = (tempoRestante / 60);
            int segundos = (tempoRestante % 60);

            Console.WriteLine($"{horas}:{minutos}:{segundos}");


        }
    }

}