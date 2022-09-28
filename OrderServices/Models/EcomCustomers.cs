using System;
using System.Collections.Generic;

namespace OrderServices.Models
{
    public partial class EcomCustomers
    {
        public EcomCustomers()
        {
            EcomOrders = new HashSet<EcomOrders>();
            EcomPayment = new HashSet<EcomPayment>();
        }

        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public string CustomerEmailId { get; set; }
        public int LoginId { get; set; }

        public virtual EcomLogin Login { get; set; }
        public virtual ICollection<EcomOrders> EcomOrders { get; set; }
        public virtual ICollection<EcomPayment> EcomPayment { get; set; }
    }
}
