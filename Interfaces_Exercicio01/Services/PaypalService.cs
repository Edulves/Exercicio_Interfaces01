namespace Interfaces_Exercicio01.Services {
    internal class PaypalService : IOnlinePaymentService {
        double PaymentFee(double amount) {
            return amount *= 1.01;
        }

        double Interest(double amount, int months) {

        }
    }
}
