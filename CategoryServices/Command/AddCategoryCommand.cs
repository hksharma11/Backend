using CategoryServices.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CategoryServices.Command
{
    public class AddCategoryCommand :IRequest<EcomCategory>
    {
        public string categoryName { get; set; }
    }
}
