using Microsoft.AspNetCore.Mvc;
using MovIedatabase.Entities.DTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MovIedatabase.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class Movies : ControllerBase
    {
        // GET: api/<Movies>
        [HttpGet(Name = "GetAllMoviesInDatabase")]
        public async Task<ActionResult<ICollection<MovieDTO>>>GetAllMovies()
        {
            throw new NotImplementedException();
        }

       
        // GET api/<Movies>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MovieDTO>> GetMovieById(int id)
        {
            throw new NotImplementedException();
        }


        // DELETE api/<Movies>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<MovieDTO>> DeleteById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
