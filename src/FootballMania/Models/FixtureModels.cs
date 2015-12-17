using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballMania.Models
{
    public class FootballFixtures
    {
        public string timeFrameStart { get; set; }
        public string timeFrameEnd { get; set; }
        public int count { get; set; }
        public List<Mainfixtures> fixtures { get; set; }
    }

    public class Mainfixtures
    {
        public FixtureLinks _links { get; set; }
        public string date { get; set; }
        public string status { get; set; }
        public int matchday { get; set; }
        public string homeTeamName { get; set; }
        public string awayTeamName { get; set; }
        public result result { get; set; }
    }

    public class result
    {
        public string goalsHomeTeam { get; set; }
        public string goalsAwayTeam { get; set; }
    }

    public class FixtureLinks
    {
        public FixtureSelf self { get; set; }
        public FixtureSoccerSeason soccerseason { get; set; }
        public FixtureHomeTeam homeTeam { get; set; }
        public FixtureAwayTeam awayTeam { get; set; }
    }

    public class FixtureSelf
    {
        public string href { get; set; }
    }

    public class FixtureSoccerSeason
    {
        public string href { get; set; }
    }

    public class FixtureHomeTeam
    {
        public string href { get; set; }
    }

    public class FixtureAwayTeam
    {
        public string href { get; set; }
    }
}
