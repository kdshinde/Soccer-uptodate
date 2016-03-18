using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
//using UnitTesting.Controllers;
//using UnitTesting.Data;
using Xunit;
using FootballMania.Controllers;
using FootballMania.Models;

namespace FootballMania.UnitTests.Controllers
{
    public class SoccerControllerTest
    {
        private SoccerController _soccercontroller;

        public SoccerControllerTest()
        {
            _soccercontroller = new SoccerController();
        }

        [Fact]
        public void GetSoccerSeasons_Test()
        {
            var result = _soccercontroller.GetSoccerSeasons();
            var viewResult = result.Result;
            var actualResult = (ViewResult)viewResult;

            var listofSeasons = (List<Season>)actualResult.ViewData.Model;

            Assert.NotEmpty(listofSeasons);

        }

        [Fact]
        public void GetAllFixtures_Test()
        {

        }

        [Fact]
        public void GetLeagueTeams_Test()
        {

        }

        [Fact]
        public void GetLeagueFixtures_Test()
        {

        }

        [Fact]
        public void GetLeagueTable_Test()
        {

        }


    }
}
