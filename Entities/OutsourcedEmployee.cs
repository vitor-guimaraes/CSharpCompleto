﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCompleto.Entities
{
    internal class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee()
        {

        }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge)
            :base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }
        override public double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }
    }
}
