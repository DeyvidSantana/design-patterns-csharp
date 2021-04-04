namespace Adapter
{
    interface IPaypalPayment
    {
        Token AuthToken();
        void PaypalPayment();
        void PaypalReceive();
    }
}
