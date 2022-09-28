using System;
using System.Collections.Generic;

namespace PaymentServices.Models
{
    public partial class EcomCategory
    {
        public EcomCategory()
        {
            EcomProducts = new HashSet<EcomProducts>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<EcomProducts> EcomProducts { get; set; }
    }
}
