using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCompleto.Intro
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        Produto produto = new Produto();

        public double ValorTotalEmEstoque()
        {
            double valor = 0;

            valor = produto.Quantidade * produto.Preco;

            return valor;
        }

        public void AdicionarProduto()
        {
            int quantidade = 0;

            Console.WriteLine("Qual a quantidade deve ser adicionada");
            quantidade = int.Parse(Console.ReadLine());

            produto.Quantidade += quantidade;

            Console.WriteLine("A quantidade total é: " + quantidade);

        }
        public void RemoverProduto()
        {
            int quantidade = 0;

            Console.WriteLine("Qual a quantidade deve ser removida");
            quantidade = int.Parse(Console.ReadLine());

            produto.Quantidade -= quantidade;

            Console.WriteLine("A quantidade total é: " + quantidade);
        }

        public void DadosProduto()
        {
            string nome = produto.Nome;
            int quantidade = produto.Quantidade;
            double preco = produto.Preco;

            Console.WriteLine("Qual o nome do produto");
            produto.Nome = Console.ReadLine();

            Console.WriteLine("Qual a quantidade");
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o preco");
            produto.Preco = double.Parse(Console.ReadLine());

            ValorTotalEmEstoque();

            Console.WriteLine("Produto {0}, Preco {1}, Quantidade {2}", nome, preco, quantidade);

            AdicionarProduto();

        }
    }
}
