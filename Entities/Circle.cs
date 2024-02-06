using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCompleto.Entities
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }        
        public Circle()
        {
            
        }

        public override double Area()
        {
            return 3.14 * Math.Sqrt(Radius);
        }
    }
}
