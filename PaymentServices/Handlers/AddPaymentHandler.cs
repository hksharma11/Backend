using MediatR;
using PaymentServices.Command;
using PaymentServices.DataLayer;
using PaymentServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PaymentServices.Handlers
{
    public class AddPaymentHandler : IRequestHandler<AddPaymentCommand, EcomPayment>
    {
        IPaymentService paymentService;

        public AddPaymentHandler(IPaymentService paymentService)
        {
            this.paymentService = paymentService;
        }

        public async Task<EcomPayment> Handle(AddPaymentCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(paymentService.AddPayment(request.orderId, request.customerId, request.paymentMode, request.cardNumber, request.cvv, request.cardExpiry, request.cardName));
        }
    }
}
