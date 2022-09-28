using ProductServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductServices.DataLayer
{
    public interface IProductService
    {
        EcomProducts AddProduct(int categoryId, string productName, string productType, decimal productPrice, string productDescription);
        List<EcomProducts> GetAllProducts();

        EcomProducts GetProductById(int productId);
    }
}
