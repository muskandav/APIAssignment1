using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIAssignment.Entities;
using APIAssignment.Interfaces;
using APIAssignment.Database;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace APIAssignment.Services
{
    public class MovieService : MovieInterface
    {
        private readonly MovieDBContext context;
        public MovieService()
        {
            this.context = new MovieDBContext();
        }
        public void AddMovie(Movie movie)
        {
            context.Movies.Add(movie);
            context.SaveChanges();
        }

        public void DeleteMovie(int id)
        {
            Movie movie = context.Movies.SingleOrDefault(i => i.MovieId == id);
            context.Movies.Remove(movie);
            context.SaveChanges();
        }

        public void EditMovie(Movie movie)
        {
            context.Movies.Update(movie);
            context.SaveChanges();
        }

        public List<Movie> GetAllMovies()
        {
            //return new List<Movie>();
            return context.Movies.ToList();
        }

        public Movie GetMovieById(int id)
        {
            Movie movie = context.Movies.SingleOrDefault(i => i.MovieId == id);
            return movie;
        }

        public List<Movie> GetMoviesByActor(string actor)
        {
            //return new List<Movie>();
            return context.Movies.Where(i => i.Actor == actor).ToList();
        }

        public List<Movie> GetMoviesByDirector(string director)
        {
            //eturn new List<Movie>();
            return context.Movies.Where(i => i.Director == director).ToList();

        }

        public List<Movie> GetMoviesByLang(string lang)
        {
            return context.Movies.Where(i => i.Lang == lang).ToList();

        }
    }
}
