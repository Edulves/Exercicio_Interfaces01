using Entities;
using System.Security.Cryptography.X509Certificates;

namespace Services {
    internal class ContractService {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService) {
            _onlinePaymentService = onlinePaymentService;
        }
        public void ProcessContract(Contract contract, int months) {

            List<DateTime> dates = new List<DateTime>();

            for (int i = 1; i <= months; i++) {
                dates.Add(contract.Date.AddMonths(i));
            }



            for (int i = 0; i < months; i++) {
                double interestfee = _onlinePaymentService.Interest(contract.TotalValue / months, i + 1);
                double paymentfee = _onlinePaymentService.PaymentFee(interestfee);
                contract.installments.Add(new Installment(dates[i], paymentfee));
            }
        }
    }
}

