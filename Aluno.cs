using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCompleto
{
    public class Aluno
    {
        public string Nome;
        public double Nota;

        public double NotaFinal(double n1, double n2, double n3)
        {
            Nota = (n1 + n2 + n3) ;
            return Nota;
        }

        public void Aprovacao()
        {
            if (Nota >= 60)
            {
                Console.WriteLine("Nota final: " + Nota);
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Nota final: " + Nota);
                Console.WriteLine("Reprovado");
                Nota = 60 - Nota;
                Console.WriteLine("Faltaram: " + Nota + " pontos");
            }
        }

    }
}
