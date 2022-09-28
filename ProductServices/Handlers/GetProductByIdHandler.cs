using MediatR;
using ProductServices.DataLayer;
using ProductServices.Models;
using ProductServices.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ProductServices.Handlers
{
    public class GetProductByIdHandler : IRequestHandler<GetProductByIdQuery, EcomProducts>
    {

        private IProductService productService;

        public GetProductByIdHandler(IProductService productService)
        {
            this.productService = productService;
        }

        public async Task<EcomProducts> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(productService.GetProductById(request.productId));
        }
    }
}
