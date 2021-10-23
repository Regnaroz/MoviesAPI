using Movies.Core.Data;
using Movies.Core.Repository;
using Movies.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Infra.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public bool DeleteCategory(int id)
        {
            return categoryRepository.DeleteCategory(id);
        }

        public List<Category> GetCategory()
        {
            return categoryRepository.GetCategory();
        }

        public bool InsertCategory(Category category)
        {
            return categoryRepository.InsertCategory(category);
        }

        public bool UpdateCategory(Category category)
        {
            return categoryRepository.UpdateCategory(category);
        }
    }
}
