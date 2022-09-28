using MediatR;
using PaymentServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentServices.Command
{
    public class AddPaymentCommand : IRequest<EcomPayment>
    {
        //int orderId, int customerId, string paymentMode, string cardNumber, int cvv, DateTime cardExpiry, string cardName

        public int orderId { get; set; }

        public int customerId { get; set; }

        public string paymentMode { get; set; }

        public string cardNumber { get; set; }

        public int cvv { get; set; }

        public DateTime cardExpiry { get; set; }

        public string cardName { get; set; }
    }
}
