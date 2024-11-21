using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moviee.ali.DTO.Add;
using Moviee.ali.DTO.Get;
using Moviee.ali.Repo.Director;

namespace Moviee.ali.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectorController : ControllerBase
    {
        private readonly IDirectorRepo _Repo;

        public DirectorController(IDirectorRepo repo)
        {
            _Repo = repo;
        }
        [HttpPost("Add category")]
        public IActionResult add( DirectorOnlyDtoAdd directorOnlyDtoAdd)
        {
            _Repo.addmovie(directorOnlyDtoAdd);
            return Created();
        }
        [HttpPut("{id}")]
        public IActionResult UpdateDirector(int id, DirectorDtoGet directorDtoGet)
        {
            _Repo.update(id, directorDtoGet);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult delete(int id)
        {
            _Repo.delete(id);
            return Ok();
        }
    }
}
