using MediatR;
using ProductServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductServices.Queries
{
    public class GetProductByIdQuery : IRequest<EcomProducts>
    {
        public int productId { get; set; }
    }
}
