using DataAccessLayer;
using Entities;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class CategoryManager
    {
        CategoryDataAccess categoryDataAccess;
        public CategoryManager()
        {
            categoryDataAccess = new CategoryDataAccess();

        }

        public List<Category> GetCategories()
        {
            return categoryDataAccess.GetCategories();
        }

    }
}
