using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieSite.Business.Abstract;
using MovieSite.Business.Concrete;
using MovieSite.Entities;

namespace MovieSite.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {

        private IMovieService _movieService;

        public MoviesController()
        {
            _movieService = new MovieManager();
        }

        [HttpGet]
        public List<Movie> Get()
        {
            return _movieService.GetAllMovies();
        }

        [HttpGet("{id}")]
        public Movie Get(int id)
        {
            return _movieService.GetMovieById(id);
        }

        [HttpPost]
        public Movie Post([FromBody] Movie movie)
        {
            return _movieService.CreateMovie(movie);
        }

        [HttpDelete("{id}")] 
        public void Delete(int id)
        {
            _movieService.DeleteMovie(id);

        }

    }
}
