﻿using System;
using System.Collections.Generic;
using System.Linq;
using CIK.MovieProject.Core;
using FluentAssertions;
using NUnit.Framework;

namespace CIK.MovieProject.Tests
{
    [TestFixture]
   public  class MovieCollectionTests
    {
        private MovieCollection _collection;
        [SetUp]
        public void SetUp()
        {
            _collection = new MovieCollection();
        }

        [Test]
        public void AddMovie_should_add_movie_to_collection()
        {
            var movie = new Movie(1, "Test");
            _collection.AddMovie(movie);

            _collection.Movies.Should().Contain(movie);
        }

        [Test]
        public void Should_not_be_able_to_add_the_same_movie_twice()
        {
            var movie = new Movie(1, "Test");
            _collection.AddMovie(movie);
            _collection.AddMovie(movie);
            _collection.Movies.Should().HaveCount(1);
      }
        [Test]
        public void Should_be_able_to_fetch_all_movies()
        {
            var movie = new Movie(1, "Test");
            _collection.AddMovie(movie);

            var movieFromCollection = _collection.Movies.First();
            movieFromCollection.Should().Be(movie);
        }
    }
}
