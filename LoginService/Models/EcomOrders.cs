using System;
using System.Collections.Generic;

namespace LoginService.Models
{
    public partial class EcomOrders
    {
        public EcomOrders()
        {
            EcomPayment = new HashSet<EcomPayment>();
        }

        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public int OrderQuantity { get; set; }
        public decimal OrderPrice { get; set; }
        public string ShipmentAddress { get; set; }

        public virtual EcomCustomers Customer { get; set; }
        public virtual EcomProducts Product { get; set; }
        public virtual ICollection<EcomPayment> EcomPayment { get; set; }
    }
}
