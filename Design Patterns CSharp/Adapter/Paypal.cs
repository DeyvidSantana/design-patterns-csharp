using System;

namespace Adapter
{
    class Paypal : IPaypalPayment
    {
        private Token token;

        public Token AuthToken()
        {
            return new Token();
        }

        public void PaypalPayment()
        {
            token = AuthToken();
            Console.WriteLine("Enviando pagamento com Paypal.");
        }

        public void PaypalReceive()
        {
            token = AuthToken();
            Console.WriteLine("Recebendo pagamento com Paypal.");
        }
    }
}
