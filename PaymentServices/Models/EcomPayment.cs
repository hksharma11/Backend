using System;
using System.Collections.Generic;

namespace PaymentServices.Models
{
    public partial class EcomPayment
    {
        public int PaymentId { get; set; }
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public string PaymentMode { get; set; }
        public string CardNumber { get; set; }
        public int? CardCvv { get; set; }
        public DateTime? CardExpiry { get; set; }
        public string CardName { get; set; }

        public virtual EcomCustomers Customer { get; set; }
        public virtual EcomOrders Order { get; set; }
    }
}
