using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCompleto
{
    public class Conta
    {
        public Conta(string numeroConta, string nome, double saldo)
        {
            NumeroConta = numeroConta;
            Nome = nome;
            Saldo = saldo;
        }

        public Conta()
        {
        }

        public string NumeroConta { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public string SetNumeroConta()
        {
            Console.WriteLine("Digite o número da conta: ");
            string numero = Console.ReadLine();
            NumeroConta = numero;
            return NumeroConta;
        }
        public string SetNome()
        {
            Console.WriteLine("Digite o seu nome: ");
            string nome = Console.ReadLine();
            Nome = nome;
            return Nome;
        }


        public double GetSaldo()
        {
            Console.WriteLine("Saldo: " + Saldo);
            return Saldo;
        }

        public void Saque()
        {
            Console.WriteLine("Digite o valor a ser sacado: ");
            double valorSaque = double.Parse(Console.ReadLine());
            Saldo = Saldo - valorSaque - 5;
            GetSaldo();
        }

        public void Deposito()
        {
            Console.WriteLine("Digite o valor a ser depositado: ");
            double valorDeposito = double.Parse(Console.ReadLine());
            Saldo = Saldo + valorDeposito;
            GetSaldo();
        }
    }
}
