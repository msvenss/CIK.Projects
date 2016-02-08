using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIK.MovieProject.Core;

namespace CIK.MovieProject
{
 public   class MovieCollection
    {
        private readonly List<Movie> _movies;
        public IEnumerable<Movie> Movies { get { return _movies; } }

        public MovieCollection()
        {
            _movies = new List<Movie>();
        }

        public void AddMovie(Movie movie)
        {
            if (!_movies.Contains(movie))
            {
                _movies.Add(movie);
            }
        }
    }

}
