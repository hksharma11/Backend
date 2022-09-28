using CategoryServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CategoryServices.DataLayer
{
    public interface ICategoryService
    {
        List<EcomCategory> GetAllCategory();
        EcomCategory GetCategoryById(int categoryId);

        EcomCategory AddCategory(string category);
    }
}
