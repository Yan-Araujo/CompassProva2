using System;
using System.Text;

namespace Frequancia
{
    class DecimaQuestao
    {
        static void Main(string[] args)
        {
            var entrada = "";
            
            while (!string.IsNullOrWhiteSpace(entrada = Console.ReadLine()))
            {
                foreach (var valorASCII in entrada)
                {
                    Console.WriteLine((int)valorASCII);
                }
            }
        }
    }
}
