using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCompleto.Intro
{
    public class Pensao
    {
        public Pensao()
        {
        }

        public Pensao(string nome, string email, int quarto)
        {
            Nome = nome;
            Email = email;
            Quarto = quarto;
        }

        public string Nome { get; set; }
        public string Email { get; set; }
        public int Quarto { get; set; }

        public void MontaVetor()
        {
            Console.WriteLine("Digite o número de hóspedes: ");
            int n = int.Parse(Console.ReadLine());

            Pensao[] vetor = new Pensao[10];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite nome, email e quarto: ");

                string nome = Console.ReadLine();
                string email = Console.ReadLine();
                int quarto = int.Parse(Console.ReadLine());

                int j = 0;
                j = quarto;
                vetor[j] = new Pensao(nome, email, quarto);
            }

            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] != null)
                {
                    Console.WriteLine("Nome: " + vetor[i].Nome);
                    Console.WriteLine("Email: " + vetor[i].Email);
                    Console.WriteLine("Quarto: " + vetor[i].Quarto);
                }
            }
        }

    }
}
