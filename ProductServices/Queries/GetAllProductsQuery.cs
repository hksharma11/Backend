using MediatR;
using ProductServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductServices.Queries
{
    public class GetAllProductsQuery : IRequest<List<EcomProducts>>
    {
    }
}
