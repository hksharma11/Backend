using CategoryServices.Command;
using CategoryServices.DataLayer;
using CategoryServices.Models;
using CategoryServices.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CategoryServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        private IMediator mediator;

        public CategoryController(IMediator mediator)
        {
            this.mediator = mediator;
        }


        [HttpGet("GetAllCategory")]
        public async Task<List<EcomCategory>> GetAllCategory()
        {
            return await mediator.Send(new GetAllCategoryQuery());
        }


        [HttpGet("GetCategoryById/{id}")]
        public async Task<EcomCategory> GetCategoryById(int id)
        {
            return await mediator.Send(new GetCategoryByIdQuery() {categoryId=id });
        }

        [HttpPost("AddCategory/{category}")]
        public async Task<EcomCategory> AddCategory(string category)
        {
            return await mediator.Send(new AddCategoryCommand { categoryName=category });
        }

    }
}
