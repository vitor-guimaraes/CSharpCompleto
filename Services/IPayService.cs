using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCompleto.Services
{
    public interface IPayService
    {
        public double PaymentFee(double value);
        public double Interest(double installment, int installmentNumber);
    }
}
