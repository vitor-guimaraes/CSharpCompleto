using System;

namespace CSharpCompleto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idadeP1;
            int idadeP2;
            string nomeP1;
            string nomeP2;
            
            Console.WriteLine("Digite nome e idade:");
            nomeP1 = Console.ReadLine();
            idadeP1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite nome e idade:");
            nomeP2 = Console.ReadLine();
            idadeP2 = int.Parse(Console.ReadLine());

            if (idadeP1 > idadeP2)
            {
                Console.WriteLine(nomeP1 + " é o mais velho");
            }
            else
            {
                Console.WriteLine(nomeP2 + "é o mais velho");
            }
            //commit
        }
    }
}
