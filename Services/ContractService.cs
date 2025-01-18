using CSharpCompleto.Entities;
using System;
using Contract = CSharpCompleto.Entities.Contract;

namespace CSharpCompleto.Services
{
    public class ContractService
    {
        private IPayService _payService;

        public ContractService(IPayService payService)
        {
            _payService = payService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double basicQuota = contract.ContractValue / months;

            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.ContractDate.AddMonths(i);
                double updatedQuota = basicQuota + _payService.Interest(basicQuota, i);
                double fullQuota = updatedQuota + _payService.PaymentFee(updatedQuota);
                contract.AddInstallment(new Installment(date, fullQuota));
            }
        }
    }

}

