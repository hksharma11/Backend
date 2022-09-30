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
    public class GetProductByCategoryIdHandler : IRequestHandler<GetProductByCategoryIdQuery, List<EcomProducts>>
    {
        IProductService productService;

        public GetProductByCategoryIdHandler(IProductService productService)
        {
            this.productService = productService;
        }

        public async Task<List<EcomProducts>> Handle(GetProductByCategoryIdQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(productService.GetProductByCategoryId(request.catId));
        }
    }
}
