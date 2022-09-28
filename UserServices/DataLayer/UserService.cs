using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserServices.Models;

namespace UserServices.DataLayer
{
    public class UserService : IUserService
    {
        EcomContext db;

        public UserService(EcomContext db)
        {
            this.db = db;
        }

        public EcomCustomers AddCustomer(string customerName, string customerAddress, string customerPhone, string customerEmail, int loginId)
        {
            var cus = new EcomCustomers()
            {
                CustomerName = customerName,
                CustomerAddress = customerAddress,
                CustomerPhoneNumber = customerPhone,
                CustomerEmailId = customerEmail,
                LoginId = loginId
             
            };
            db.EcomCustomers.Add(cus);
            db.SaveChanges();
            return cus;
        }

       

        public EcomCustomers GetCustomerById(int customerId)
        {
            return db.EcomCustomers.SingleOrDefault(x => x.CustomerId == customerId);
        }
    }
}
