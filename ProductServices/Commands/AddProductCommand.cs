using MediatR;
using ProductServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductServices.Commands
{
    public class AddProductCommand : IRequest<EcomProducts>
    {
        

        public int categoryId { get; set; }

        public string productName { get; set; }

        public string productType { get; set; }

        public decimal productPrice { get; set; }

        public string productDescription { get; set; }

    }
}
