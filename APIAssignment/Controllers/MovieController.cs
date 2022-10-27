
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIAssignment.Entities;
using APIAssignment.Services;

namespace APIAssignment.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly MovieService service;
        public MovieController()
        {
            this.service = new MovieService();
        }
        [Route("GetAllMovies")]
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Movie> movies = service.GetAllMovies();
            return StatusCode(200, movies);
        }


        [Route("GetAllMoviesByDirector/{director}")]
        [HttpGet]
        public IActionResult GetAll(string director)
        {
            List<Movie> movies = service.GetMoviesByDirector(director);
            return StatusCode(200, movies);
        }

        [Route("GetAllMoviesByLang/{lang}")]
        [HttpGet]
        public IActionResult GetAllByLang(string lang)
        {
            List<Movie> movies = service.GetMoviesByLang(lang);
            return StatusCode(200, movies);
        }

        [Route("GetAllMoviesByActor/{actor}")]
        [HttpGet]
        public IActionResult GetAllByActor(string actor)
        {
            List<Movie> movies = service.GetMoviesByActor(actor);
            return StatusCode(200, movies);
        }

        [HttpGet]
        [Route("Get/{id}")]
        public IActionResult Get(int id)
        {
            Movie movie = service.GetMovieById(id);
            return StatusCode(200, movie);
        }
        [HttpPost]
        [Route("Add")]
        public IActionResult Add(Movie movie)
        {
            service.AddMovie(movie);
            return StatusCode(200, movie);
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            service.DeleteMovie(id);
            return StatusCode(200, "Movies with " + id + " Deleted");
        }
        [HttpPut]
        [Route("Edit")]
        public IActionResult Edit(Movie movie)
        {
            service.EditMovie(movie);
            return StatusCode(200, movie);
        }

    }
}
