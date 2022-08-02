using MovieSite.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSite.Business.Abstract
{
    public interface IMovieService
    {
        List<Movie> GetAllMovies();
        Movie GetMovieById(int id);
        Movie CreateMovie(Movie movie);

        Movie UpdateMovie(Movie movie);

        void DeleteMovie(int id);




    }
}
