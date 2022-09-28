using CategoryServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CategoryServices.DataLayer
{
    public class CategoryService : ICategoryService
    {
        EcomContext db;

        public CategoryService(EcomContext db)
        {
            this.db = db;
        }

     

        public EcomCategory AddCategory(string category)
        {
            var cat = new EcomCategory()
            {
                CategoryName = category
            };
            db.EcomCategory.Add(cat);
            db.SaveChanges();
            return cat;
        }

        public List<EcomCategory> GetAllCategory()
        {
            return db.EcomCategory.ToList();
        }

        public EcomCategory GetCategoryById(int categoryId)
        {
            return db.EcomCategory.SingleOrDefault(x => x.CategoryId == categoryId);
        }
    }
}
