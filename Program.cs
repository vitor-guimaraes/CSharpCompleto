using System;


namespace CSharpCompleto
{
    class Program
    {
        static void Main(string[] args)
        {

            #region exProps
            Conta conta = new Conta();

            conta.SetNumeroConta();
            conta.SetNome();

            Console.WriteLine("Depósito inicial? s/n ");
            char x = char.Parse(Console.ReadLine());

            if (x == 's')
            {
                conta.SetDepositoInicial();
            }

            conta.Deposito();
            conta.Saque();


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
        }
    }
}
