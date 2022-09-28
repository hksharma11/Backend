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
    public class GetAllProductsHandler : IRequestHandler<GetAllProductsQuery, List<EcomProducts>>
    {

        private IProductService productService;

        public GetAllProductsHandler(IProductService productService)
        {
            this.productService = productService;
        }

        public async Task<List<EcomProducts>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(productService.GetAllProducts());
        }
    }
}
