using OrderServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderServices.DataLayer
{
   public interface IOrderService
    {
        List<EcomOrders> GetAllOrders();

        EcomOrders GerOrderById(int orderId);

        EcomOrders AddOrder(int productId, int customerId,int quantity, decimal price, string shippment_address);
    }
}
