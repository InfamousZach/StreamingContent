using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StreamingContent_Repository;

namespace StreamingContent_Tests
{
    [TestClass]
    public class MovieTest
    {
        [TestMethod]
        public void MovieTest1()
        {
    Movie_Repository _repo = new Movie_Repository();

    Movie movie = new Movie();
    movie.Title = "Double Down";
    movie.Description = "A brilliant computer loner seizes Las Vegas and its terrorist attack, while fighting against his fits of clinical depression and obsession for romance and death.";
    movie.Director = "Neil Breen";
    movie.RunTime = 93;

    _repo.AddMovieContent(movie);
        }
    }
}