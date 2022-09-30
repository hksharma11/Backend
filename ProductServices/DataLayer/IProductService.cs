using ProductServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductServices.DataLayer
{
    public interface IProductService
    {
        EcomProducts AddProduct(EcomProducts product);
        List<EcomProducts> GetAllProducts();

        EcomProducts GetProductById(int productId);

        List<EcomProducts> GetProductByCategoryId(int catId);
    }
}
