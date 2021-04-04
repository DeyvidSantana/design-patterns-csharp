namespace Adapter
{
    class MercadoPagoAdapter : IPaypalPayment
    {
        private MercadoPago _mercadoPago;

        public MercadoPagoAdapter(MercadoPago mercadoPago)
        {
            _mercadoPago = mercadoPago;
        }

        public Token AuthToken()
        {
            return _mercadoPago.AuthToken();
        }

        public void PaypalPayment()
        {
            _mercadoPago.MercadoPagoPayment();
        }

        public void PaypalReceive()
        {
            _mercadoPago.MercadoPagoReceive();
        }
    }
}
