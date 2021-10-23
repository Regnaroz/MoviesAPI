using Movies.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Core.Service
{
    public interface ICategoryService
    {
        public List<Category> GetCategory();
        public bool InsertCategory(Category category);
        public bool UpdateCategory(Category category);
        public bool DeleteCategory(int id);
    }
}
