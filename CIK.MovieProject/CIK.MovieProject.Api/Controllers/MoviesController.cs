﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using CIK.MovieProject.Core;

namespace CIK.MovieProject.Api.Controllers
{
    public class MoviesController : ApiController
    {
        public IEnumerable<Movie> Get()
        {
            return Storage.Collection.Movies;
                
        }

        public Movie Get(int id)
        {
            var movie = Storage.Collection.Movies.FirstOrDefault(x => x.Id == id);
            return movie;
        }

        public void Post(CreateMovie input)
        {
            Storage.Collection.AddMovie(new Movie(input.Id, input.Name));
        }

        public class CreateMovie
        {
            public int Id { get; set; }
        public string Name { get; set; }

        }

    }

}
