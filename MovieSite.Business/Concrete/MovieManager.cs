using MovieSite.Business.Abstract;
using MovieSite.DataAccess.Abstract;
using MovieSite.DataAccess.Concrete;
using MovieSite.Entities;
using System;

namespace MovieSite.Business.Concrete
{
    public class MovieManager : IMovieService
    {

        private IMovieRepository _movieRepository;

        public MovieManager()
        {
            _movieRepository = new MovieRepository();
        }

        public Movie CreateMovie(Movie movie)
        {
            return _movieRepository.CreateMovie(movie);


        }

        public void DeleteMovie(int id)
        {
            _movieRepository.DeleteMovie(id);
        }

        public List<Movie> GetAllMovies()
        {
            return _movieRepository.GetAllMovies();
        }

        public Movie GetMovieById(int id)
        {
            if (id > 0)
            {
                return _movieRepository.GetMovieById(id);

            }
            throw new Exception("id can not be less than 1");

        }

        public Movie UpdateMovie(Movie movie)
        {
            return _movieRepository.UpdateMovie(movie);
        }
    }
}