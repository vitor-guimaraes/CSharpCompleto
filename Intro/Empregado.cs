using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCompleto.Intro
{
    public class Empregado
    {
        public Empregado(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public void AumentoSalario(double porcentagem)
        {
            Salario += Salario * porcentagem / 100;
        }
    }
}
