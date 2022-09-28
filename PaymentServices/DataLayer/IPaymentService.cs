using PaymentServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentServices.DataLayer
{
    public interface IPaymentService
    {
        EcomPayment AddPayment(int orderId, int customerId, string paymentMode,string cardNumber, int cvv, DateTime cardExpiry, string cardName);
    }
}
