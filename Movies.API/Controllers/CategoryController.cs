using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movies.Core.Data;
using Movies.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly ICategoryService categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }
        [ProducesResponseType(typeof(List<Category>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Category), StatusCodes.Status400BadRequest)]
        [Route("DeleteCategory/{id}")]
        [HttpDelete]
        public bool DeleteCategory(int id)
        {
            return categoryService.DeleteCategory(id);
        }
        [ProducesResponseType(typeof(List<Category>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Category), StatusCodes.Status400BadRequest)]
        [Route("GetCategory")]
        [HttpGet]
        public List<Category> GetCategory()
        {
            return categoryService.GetCategory();
        }
        [ProducesResponseType(typeof(List<Category>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Category), StatusCodes.Status400BadRequest)]
        [Route("InsertCategory")]
        [HttpPost]
        public bool InsertCategory(Category category)
        {
            return categoryService.InsertCategory(category);
        }
        [ProducesResponseType(typeof(List<Category>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Category), StatusCodes.Status400BadRequest)]
        [Route("UpdateCategory")]
        [HttpPut]
        public bool UpdateCategory(Category category)
        {
            return categoryService.UpdateCategory(category);
        }
    }
}
