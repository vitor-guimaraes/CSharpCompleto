using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCompleto.Entities
{
    internal class TaxpayerIndividual : Taxpayer
    {
        public double Health { get; set; }
        public TaxpayerIndividual(string name, double income, double health)
            : base(name, income)
        {
            Health = health;
        }

        public override double Tax()
        {
            if (Income > 20000)
            {
                return Income * 0.25 - Health * 0.5;
            }
            else
            {
                return Income * 0.15 - Health * 0.5;
            }
        }
    }
}
