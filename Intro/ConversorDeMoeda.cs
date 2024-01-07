using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCompleto.Intro
{
    class ConversorDeMoeda
    {
        public double CotDolar;
        public double Dolares;

        public static double Conversao(double cotDolar, double dolares)
        {
            return 1.06 * (cotDolar * dolares);
        }
    }
}
