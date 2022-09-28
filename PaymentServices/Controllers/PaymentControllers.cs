using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PaymentServices.Command;
using PaymentServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentControllers : ControllerBase
    {

        private IMediator mediator;

        public PaymentControllers(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost("AddPayment/{orderId}/{customerId}/{paymentMode}/{cardNumber}/{cvv}/{cardExpiry}/{cardName}")]
        public async Task<EcomPayment> AddPayment(int orderId, int customerId, string paymentMode, string cardNumber, int cvv, DateTime cardExpiry, string cardName)
        {
            return await mediator.Send(new AddPaymentCommand { orderId= orderId, customerId=customerId,paymentMode=paymentMode,cardNumber=cardNumber,cvv=cvv,cardExpiry=cardExpiry,cardName=cardName });
        }
    }
}
