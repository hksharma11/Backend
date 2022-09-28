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
    public class GetAllCategoryHandler : IRequestHandler<GetAllCategoryQuery, List<EcomCategory>>
    {

        private ICategoryService categoryService;

        public GetAllCategoryHandler(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        public async Task<List<EcomCategory>> Handle(GetAllCategoryQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(categoryService.GetAllCategory());
        }
    }
}
