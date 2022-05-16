using System;
using System.Globalization;
using System.Text;
namespace OitavoExercicio
{
    public class fraseDancando
    {
        static void Main(string[] args)
        {
            var fraseDancante = new StringBuilder();
            string frase = "";



            while (!string.IsNullOrWhiteSpace(frase = Console.ReadLine()))
            {
                var eMaiuscula = false;

                foreach (var letraTestada in frase)
                {

                    if (letraTestada == ' ')
                    {
                        fraseDancante.Append(" ");
                    }
                    else if (eMaiuscula == false)
                    {
                        fraseDancante.Append(char.ToUpper(letraTestada));

                        eMaiuscula = true;
                    }
                    else
                    {
                        fraseDancante.Append(char.ToLower(letraTestada));

                        eMaiuscula = false;
                    }

                }

                fraseDancante.Append(Environment.NewLine);

            }


            Console.Write(fraseDancante);
        }
    }

}