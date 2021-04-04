using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //var payment = new Paypal();
            //var payment = new PayonnerAdapter(new Payonner());
            var payment = new MercadoPagoAdapter(new MercadoPago());

            payment.PaypalPayment();
            payment.PaypalReceive();

            //payment.SendPayment();
            //payment.ReceivePayment();

            Console.ReadLine();
        }
    }
}
