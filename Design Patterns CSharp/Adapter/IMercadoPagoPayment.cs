using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    interface IMercadoPagoPayment
    {
        Token AuthToken();
        void MercadoPagoPayment();
        void MercadoPagoReceive();
    }
}
