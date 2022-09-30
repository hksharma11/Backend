using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductServices.Commands;
using ProductServices.DataLayer;
using ProductServices.Models;
using ProductServices.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private IMediator mediator;

        public ProductController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("GetAllProducts")]
        public async Task<List<EcomProducts>> GetAllProducts()
        {
            return await mediator.Send(new GetAllProductsQuery());
        }

        [HttpGet("GetProductByCategoryId/{catId}")]
        public async Task<List<EcomProducts>> GetProductByCategoryId(int catId)
        {
            return await mediator.Send(new GetProductByCategoryIdQuery { catId=catId });
        }

        [HttpGet("GetProductById/{productId}")]
        public async Task<EcomProducts> GetProductbyId(int productId)
        {
            return await mediator.Send(new GetProductByIdQuery { productId=productId});
        }

        [HttpPost("AddProduct")]
        public async Task<EcomProducts> AddProduct([FromBody] EcomProducts prod)
        {
            return await mediator.Send(new AddProductCommand {product=prod});
        }


    }
}
