using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace CSharpCompleto
{
    public class Retangulo
    {
        public double Altura;
        public double Largura;

        public double Area()
        {
            return Altura * Largura;
        }

        public double Perimetro()
        {
            return ((2*Altura) + (2*Largura));
        }

        public double Diagonal()
        {
            return Sqrt((Pow(Altura, 2) + Pow(Largura, 2)));
        }
    }
}
