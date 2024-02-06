using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCompleto.Entities
{
    public abstract class Taxpayer
    {
        protected Taxpayer(string name, double income)
        {
            Name = name;
            Income = income;
        }

        public string Name { get; set; }

        public double Income { get; set; }

        abstract public double Tax();
    }
}
