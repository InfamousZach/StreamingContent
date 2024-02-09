using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StreamingContent_Repository;

namespace StreamingContent_Tests
{
    [TestClass]
    public class ShowTest
    {
        [TestMethod]
        public void ShowTest1()
        {
    Show_Repository _repo = new Show_Repository();

    Show show = new Show();
    show.Title = "Funny Jokes";
    show.Description = "Tells funny jokes to an audiance";

    // Add a few Episodes as well:

    Episode episode1 = new Episode();
    episode1.Name = "Top Banana";
    episode1.RunTime = 22;

    Episode episode2 = new Episode();
    episode2.Name = "Bringing Up Buster";
    episode2.RunTime = 22;

    Episode episode3 = new Episode();
    episode3.Name = "Key Decisions";
    episode3.RunTime = 22;

    show.Episodes.Add(episode1);
    show.Episodes.Add(episode2);
    show.Episodes.Add(episode3);

    _repo.AddContentToDirectory(show);
        }
    }
}