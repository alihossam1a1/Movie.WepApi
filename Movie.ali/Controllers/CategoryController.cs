using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moviee.ali.DTO.Add;
using Moviee.ali.Repo.Category;

namespace Moviee.ali.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepo _Repo;

        public CategoryController(ICategoryRepo repo)
        {
            _Repo = repo;
        }
        [HttpPost("add category")]
        public IActionResult add(CategoryDtoAdd categoryDtoAdd)
        {
            _Repo.addcategory(categoryDtoAdd);
            return Created();
        }
        [HttpPut("{id}")]
        public IActionResult update(int id, CategoryDtoAdd categoryDtoAdd)
        {
            _Repo.updatecategory(id, categoryDtoAdd);
            return Ok();
        }
    }
}
