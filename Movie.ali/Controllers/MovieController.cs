using Microsoft.AspNetCore.Mvc;
using Moviee.ali.DTO.Get;
using Moviee.ali.Repo.Movie;
using Moviee.ali;


namespace Moviee.ali.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieRepo _Repo;

        public MovieController(IMovieRepo repo)
        {
            _Repo = repo;
        }
        [HttpGet("Get All Data")]
        public IActionResult Get()
        {
            var res = _Repo.Getall();
            return Ok(res);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var res = _Repo.Get(id);
            if (res == null)
            {
                return NotFound();
            }
            return Ok(res);
        }
        [HttpPost("Add All")]
        public IActionResult Addall(MovieDtoGet movieDtoGet)
        {
            _Repo.addmovie(movieDtoGet);
            if (movieDtoGet != null)
            {
                return Ok();
            }
            return BadRequest();

        }
    }
}
