using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserServices.Models;

namespace UserServices.DataLayer
{
    public interface IUserService
    {
        EcomCustomers GetCustomerById(int customerId);

        EcomCustomers AddCustomer(string customerName, string customerAddress, string customerPhone, string customerEmail, int loginId);
    }
}
