using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIK.MovieProject.Core
{
    public class Movie

    {
        public int Id { get; }
        public string Name { get; }

        public Movie (int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
