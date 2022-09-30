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

        public EcomProducts AddProduct(EcomProducts product)
        {
           

         

            db.EcomProducts.Add(product);
            db.SaveChanges();
            return product;

        }

        public List<EcomProducts> GetAllProducts()
        {
            return db.EcomProducts.ToList();
        }

        public EcomProducts GetProductById(int productId)
        {
            return db.EcomProducts.SingleOrDefault(x => x.ProductId == productId);
        }

        public List<EcomProducts> GetProductByCategoryId(int catId)
        {
            return db.EcomProducts.Where(x => x.CategoryId == catId).ToList();
        }
    }
}
