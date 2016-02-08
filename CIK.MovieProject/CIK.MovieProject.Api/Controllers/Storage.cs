using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIK.MovieProject.Core;

namespace CIK.MovieProject.Api.Controllers
{
    public class Storage
    {

        public static MovieCollection Collection = new MovieCollection();

        static Storage()
        {
            Collection.AddMovie(new Movie(1, "I'm batman"));
            Collection.AddMovie(new Movie(2, "Titanic"));
        }
    }
}
