using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCompleto.Entities
{
    public class Rectangle : Shape
    {
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }    
        public Rectangle()
        {

        }

        public double Width { get; set; }
        public double Height { get; set; }
        public override double Area()
        {
            return Width * Height;
        }
    }
}
