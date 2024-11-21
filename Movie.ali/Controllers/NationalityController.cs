using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moviee.ali.DTO.Get;
using Moviee.ali.Repo.Nationality;

namespace Moviee.ali.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NationalityController : ControllerBase
    {
        private readonly INationalityRepo _Repo;

        public NationalityController(INationalityRepo repo)
        {
            _Repo = repo;
        }
        [HttpPost("add Nationality")]
        public IActionResult add(NationalityDtoGet nationalityDtoGet)
        {
            _Repo.addNationality(nationalityDtoGet);
            return Created();
        }
        [HttpDelete("{id}")]
        public IActionResult delete(int id)
        {
            _Repo.Delete(id);
            return Ok();
        }

    }
}
