using CategoryServices.DataLayer;
using CategoryServices.Models;
using CategoryServices.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CategoryServices.Handlers
{
    public class GetCategoryByIdHandler : IRequestHandler<GetCategoryByIdQuery, EcomCategory>
    {

        private ICategoryService categoryService;

        public GetCategoryByIdHandler(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        public async Task<EcomCategory> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(categoryService.GetCategoryById(request.categoryId));
        }
    }
}
