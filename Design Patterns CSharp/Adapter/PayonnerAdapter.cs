namespace Adapter
{
    class PayonnerAdapter : IPaypalPayment
    {
        private Payonner payonner;
        public PayonnerAdapter(Payonner payonner)
        {
            this.payonner = payonner;
        }

        public Token AuthToken()
        {
            return payonner.AuthToken();
        }

        public void PaypalPayment()
        {
            payonner.SendPayment();
        }

        public void PaypalReceive()
        {
            payonner.ReceivePayment();
        }
    }
}
