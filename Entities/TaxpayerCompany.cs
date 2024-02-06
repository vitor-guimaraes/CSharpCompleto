using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCompleto.Entities
{
    internal class TaxpayerCompany : Taxpayer
    {
        public int Workers { get; set; }
        public TaxpayerCompany(string name, double income, int workers) 
            : base(name, income)
        {
            Workers = workers;
        }

        public override double Tax()
        {
           if (Workers > 0)
           {
               return Income * 0.14;
           }
           else
           {
               return Income * 0.16;
           }

        }
    }
}
