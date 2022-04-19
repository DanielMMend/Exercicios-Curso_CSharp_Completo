using System;
using S14_Exercicio_Interface_2.Entities;

namespace S14_Exercicio_Interface_2.Services
{
    class ContractService
    {
        public IOnlinePaymentService PaymentService { get; set; }

        public ContractService(IOnlinePaymentService paymentService)
        {
            PaymentService = paymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            for (int i = 1; i <= months; i++)
            {
                double basicQuota = contract.TotalValue / months;
                double updatedQuota = basicQuota + PaymentService.Interest(basicQuota, i);
                double fullQuota = updatedQuota + PaymentService.PaymentFee(updatedQuota);

                DateTime iDate = contract.Date.AddMonths(i);

                Installment installment = new Installment(iDate, fullQuota);
                contract.AddInstalment(installment);
            }
        }
    }
}
