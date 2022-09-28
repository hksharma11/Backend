using ProductServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductServices.DataLayer
{
    public class ProductService : IProductService
    {
        EcomContext db;

        public ProductService(EcomContext db)
        {
            this.db = db;
        }

        public EcomProducts AddProduct(int categoryId, string productName, string productType, decimal productPrice, string productDescription)
        {
            var prod = new EcomProducts()
            {
                CategoryId = categoryId,
                ProductName=productName,
                ProductType=productType,
                ProductPrice= productPrice,
                ProductDescription = productDescription
            };

           

            db.EcomProducts.Add(prod);
            db.SaveChanges();
            return prod;

        }

        public List<EcomProducts> GetAllProducts()
        {
            return db.EcomProducts.ToList();
        }

        public EcomProducts GetProductById(int productId)
        {
            return db.EcomProducts.SingleOrDefault(x => x.ProductId == productId);
        }
    }
}
