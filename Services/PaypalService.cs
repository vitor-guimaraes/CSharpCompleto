using CSharpCompleto.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCompleto.Services
{
    public class PaypalService : IPayService
    {
        public double PaymentFee(double value)
        {
            return value * 0.02;
        }

        public double Interest(double installment, int installmentNumber)
        {
            return installment * 0.01 * installmentNumber;
        }

    }
}
