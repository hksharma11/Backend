using PaymentServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentServices.DataLayer
{
    public class Payment : IPaymentService
    {
        EcomContext db;

        public Payment(EcomContext db)
        {
            this.db = db;
        }

        public EcomPayment AddPayment(int orderId, int customerId, string paymentMode, string cardNumber, int cvv, DateTime cardExpiry, string cardName)
        {
            var pay = new EcomPayment()
            {
                OrderId=orderId,
                CustomerId = customerId,
                PaymentMode = paymentMode,
                CardNumber = cardNumber,
                CardCvv =cvv,
                CardExpiry = cardExpiry,
                CardName = cardName

            };

            db.EcomPayment.Add(pay);
            db.SaveChanges();
            return pay;
        }
    }
}
