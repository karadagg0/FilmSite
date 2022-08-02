using MovieSite.DataAccess.Abstract;
using MovieSite.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSite.DataAccess.Concrete
{
    public class MovieRepository : IMovieRepository
    {
        public Movie CreateMovie(Movie movie)
        {
            using (var movieDbContext = new MovieDbContext())
            {
                 movieDbContext.Movies.Add(movie);
               movieDbContext.SaveChanges();
                return movie;
            }
        }

        public void DeleteMovie(int id)
        {
            using(var movieDbContext = new MovieDbContext())
            {
                var deletedMovie = GetMovieById(id);
                movieDbContext.Movies.Remove(deletedMovie);
                movieDbContext.SaveChanges();
            }
           
        }

        public List<Movie> GetAllMovies()
        {
            using (var movieDbContext = new MovieDbContext())
            {
                return movieDbContext.Movies.ToList();
            }
        }

        public Movie GetMovieById(int id)
        {
            using (var movieDbContext = new MovieDbContext())
            {
                return movieDbContext.Movies.Find(id);
            }
        }

        public Movie UpdateMovie(Movie movie)
        {
            using (var movieDbContext = new MovieDbContext())
            {
                 movieDbContext.Movies.Update(movie);
                movieDbContext.SaveChanges();
                return movie;
            }
        }
    }
}
