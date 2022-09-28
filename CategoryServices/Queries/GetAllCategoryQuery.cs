using CategoryServices.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CategoryServices.Queries
{
    public class GetAllCategoryQuery : IRequest<List<EcomCategory>>
    {
    }
}
