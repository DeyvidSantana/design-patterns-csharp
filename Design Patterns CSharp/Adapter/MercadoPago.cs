using System;

namespace Adapter
{
    class MercadoPago : IMercadoPagoPayment
    {
        private Token token;

        public Token AuthToken()
        {
            return new Token();
        }

        public void MercadoPagoPayment()
        {
            token = AuthToken();
            Console.WriteLine("Enviando pagamento com Mercado Pago.");
        }

        public void MercadoPagoReceive()
        {
            token = AuthToken();
            Console.WriteLine("Recebendo pagamento com Mercado Pago.");
        }
    }
}
