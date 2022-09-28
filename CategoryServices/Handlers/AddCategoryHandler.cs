using CategoryServices.Command;
using CategoryServices.DataLayer;
using CategoryServices.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CategoryServices.Handlers
{
    public class AddCategoryHandler : IRequestHandler<AddCategoryCommand, EcomCategory>
    {
        private ICategoryService categoryService;

        public AddCategoryHandler(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        public async Task<EcomCategory> Handle(AddCategoryCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(categoryService.AddCategory(request.categoryName));
        }
    }
}
