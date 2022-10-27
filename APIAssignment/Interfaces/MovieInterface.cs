using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIAssignment.Entities;
namespace APIAssignment.Interfaces
{
    public interface MovieInterface
    {
        List<Movie> GetAllMovies();
        List<Movie> GetMoviesByActor(string actor);
        List<Movie> GetMoviesByLang(string lang);
        List<Movie> GetMoviesByDirector(string director);
        Movie GetMovieById(int id);
        void AddMovie(Movie movie);
        void DeleteMovie(int id);
        void EditMovie(Movie movie);
        
    }
}
