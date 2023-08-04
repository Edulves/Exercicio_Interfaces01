namespace Services {
    internal class PaypalService : IOnlinePaymentService {
        public double PaymentFee(double amount) {
            return amount *= 1.02;
        }

        public double Interest(double amount, int months) {
            return amount *= ((months * 0.01) + 1);
        }
    }
}
