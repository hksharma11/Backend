using MediatR;
using ProductServices.Commands;
using ProductServices.DataLayer;
using ProductServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ProductServices.Handlers
{
    public class AddProductHandler : IRequestHandler<AddProductCommand, EcomProducts>
    {
        private IProductService productService;

        public AddProductHandler(IProductService productService)
        {
            this.productService = productService;
        }

        public async Task<EcomProducts> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(productService.AddProduct(request.categoryId, request.productName, request.productType, request.productPrice, request.productDescription));
        }
    }
}
