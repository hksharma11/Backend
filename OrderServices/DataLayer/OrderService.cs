using OrderServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderServices.DataLayer
{
    public class OrderService : IOrderService
    {
        EcomContext db;

        public OrderService(EcomContext db)
        {
            this.db = db;
        }

        public EcomOrders AddOrder(int productId, int customerId, int quantity, decimal price, string shippment_address)
        {
            var order = new EcomOrders()
            {
                ProductId = productId,
                CustomerId = customerId,
                OrderQuantity = quantity,
                OrderPrice = price,
                ShipmentAddress = shippment_address
            };
            db.EcomOrders.Add(order);
            db.SaveChanges();
            return order;
        }

        public EcomOrders GerOrderById(int orderId)
        {
            return db.EcomOrders.SingleOrDefault(x => x.OrderId == orderId);
        }

        public List<EcomOrders> GetAllOrders()
        {
            return db.EcomOrders.ToList();
        }
    }
}
