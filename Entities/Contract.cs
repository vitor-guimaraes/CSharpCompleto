using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCompleto.Entities
{
    public class Contract
    {
        public Contract(int contractNumber, DateTime contractDate, double contractValue)
        {
            ContractNumber = contractNumber;
            ContractDate = contractDate;
            ContractValue = contractValue;
            Installments = new List<Installment>();
        }

        public int ContractNumber { get; set; }
        public DateTime ContractDate { get; set; }
        public double ContractValue { get; set; }
        public List<Installment> Installments { get; set; }
        public void AddInstallment(Installment installment)
        {
            Installments.Add(installment);
        }
    }

}
