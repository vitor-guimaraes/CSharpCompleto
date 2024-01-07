using System;
using System.Collections.Generic;
using CSharpCompleto.Entities;
using CSharpCompleto.Entities.Enums;
using CSharpCompleto.Intro;

namespace CSharpCompleto
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);

            ///////////////
            #region Intro

            #region exMatrizes
            //Matriz matriz = new Matriz();

            //matriz.MontaMatriz();

            //matriz.MatrizEx();


            #endregion

            #region exListas

            //Console.WriteLine("Digite o número de empregados: ");
            //int n = int.Parse(Console.ReadLine());

            //List <Empregado> empregados = new List<Empregado>();

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("Empregado #" + (i+1) + ":");

            //    Console.WriteLine("Digite o Id: ");
            //    int id = int.Parse(Console.ReadLine());    

            //    Console.WriteLine("Digite o Nome: ");
            //    string nome = Console.ReadLine();

            //    Console.WriteLine("Digite o Salário: ");
            //    double salario = double.Parse(Console.ReadLine());

            //    Empregado empregado = new Empregado(id, nome, salario);

            //    empregados.Add(empregado);
            //}

            //foreach (Empregado empregado in empregados)
            //{                
            //    Console.Write("Id: " + empregado.Id + ", ");
            //    Console.Write("Nome: " + empregado.Nome + ", ");
            //    Console.Write("Salario: " + empregado.Salario);
            //    Console.WriteLine(" ");
            //}

            //Console.Write("Digite o Id do empregado que receberá aumento: ");
            //int procuraId = int.Parse(Console.ReadLine());

            //Empregado emp = empregados.Find(x => x.Id == procuraId);
            //if (emp != null)
            //{
            //    Console.Write("Enter the percentage: ");
            //    double porcentagem = double.Parse(Console.ReadLine());
            //    emp.AumentoSalario(porcentagem);
            //}
            //else
            //{
            //    Console.WriteLine("Id inválido");
            //}

            //Console.WriteLine();
            //Console.WriteLine("Lista atualizada de empregados:");
            //foreach (Empregado obj in empregados)
            //{
            //    Console.WriteLine(obj.Id + " " + obj.Nome + " " + obj.Salario);
            //}

            #endregion

            #region exVetores
            //Pensao pensao = new Pensao();

            //pensao.MontaVetor();
            #endregion

            #region exProps
            //Conta conta = new Conta();

            //conta.SetNumeroConta();
            //conta.SetNome();

            //Console.WriteLine("Depósito inicial? s/n ");
            //char x = char.Parse(Console.ReadLine());

            //if (x == 's')
            //{
            //    conta.Deposito();
            //}

            //conta.Deposito();
            //conta.Saque();
            #endregion

            #region exStatic
            //Console.WriteLine("Cotação do dolar: ");
            //    double cotDolar = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Quantidade de dolares: ");
            //    double dolares = double.Parse(Console.ReadLine());

            //    Console.WriteLine(ConversorDeMoeda.Conversao(cotDolar, dolares));
            #endregion

            #region ex3
            //Aluno aluno = new Aluno();
            //double n1;
            //double n2;
            //double n3;

            //Console.WriteLine("Nome: ");
            //aluno.Nome = Console.ReadLine();

            //Console.WriteLine("Digite as tres notas: ");
            //n1 = double.Parse(Console.ReadLine());
            //n2 = double.Parse(Console.ReadLine());
            //n3 = double.Parse(Console.ReadLine());

            //aluno.NotaFinal(n1, n2, n3);

            //aluno.Aprovacao();
            #endregion

            #region ex2
            //Funcionario funcionario = new Funcionario();

            //string nome = funcionario.Nome;
            //double salarioBruto = funcionario.SalarioBruto;
            //double imposto = funcionario.Imposto;
            //double salarioLiquido;
            //double aumento;

            //Console.WriteLine("Nome: ");
            //funcionario.Nome = Console.ReadLine();
            //Console.WriteLine("Salario Bruto: ");
            //funcionario.SalarioBruto = double.Parse(Console.ReadLine());
            //Console.WriteLine("Imposto: ");
            //funcionario.Imposto = double.Parse(Console.ReadLine());

            //salarioLiquido = funcionario.SalarioLiquido();

            //Console.WriteLine("Funcionario {0}, Salario: {1}", nome, salarioLiquido);

            //Console.WriteLine("Digite o aumento em %: ");
            //aumento = double.Parse(Console.ReadLine());
            //funcionario.AumentarSalario(aumento);

            //Console.WriteLine("Funcionario {0}, Salario: {1}", nome, funcionario.SalarioBruto);
            #endregion

            #region ex1
            //Retangulo retangulo = new Retangulo();
            //double area;
            //double perimetro;
            //double diagonal;

            //Console.WriteLine("Digite a largura do retangulo: ");
            //retangulo.Largura = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite a altura do retangulo: ");
            //retangulo.Altura = double.Parse(Console.ReadLine());

            //area = retangulo.Area();
            //Console.WriteLine("Area: " + area);

            //perimetro = retangulo.Perimetro();
            //Console.WriteLine("Perimetro: " + perimetro);

            //diagonal = retangulo.Diagonal();
            //Console.WriteLine("Diagonal: " + diagonal);
            #endregion

            #region prog1
            //Pessoa A, B;
            //A = new Pessoa();
            //B = new Pessoa();

            //Console.WriteLine("Qual o seu nome");
            //A.Nome = Console.ReadLine();
            //Console.WriteLine("Qual a sua idade");
            //A.Idade = int.Parse(Console.ReadLine());

            //Console.WriteLine("Qual o seu nome");
            //B.Nome = Console.ReadLine();
            //Console.WriteLine("Qual a sua idade");
            //B.Idade = int.Parse(Console.ReadLine());

            //if (A.Idade > B.Idade)
            //{
            //    Console.WriteLine(A.Nome + " é o mais velho");
            //}
            //else
            //{
            //    Console.WriteLine(B.Nome + " é o mais velho");
            //}
            #endregion

            #endregion
        }
    }
}
