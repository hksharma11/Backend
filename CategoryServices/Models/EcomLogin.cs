using System;
using System.Collections.Generic;

namespace CategoryServices.Models
{
    public partial class EcomLogin
    {
        public EcomLogin()
        {
            EcomCustomers = new HashSet<EcomCustomers>();
        }

        public int LoginId { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
        public DateTime DateTimeStamp { get; set; }
        public string LoginRole { get; set; }

        public virtual ICollection<EcomCustomers> EcomCustomers { get; set; }
    }
}
