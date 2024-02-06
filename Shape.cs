using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCompleto.Entities
{
    abstract public class Shape
    {
        public string Color { get; set; }

        abstract public double Area();
    }
}
