using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballMania.Models
{
    public class LeagueTable
    {
        public int matchday { get; set; }
        public string leagueCaption { get; set; }
        public LeagueTable_links _links { get; set; }
        public List<LeagueStanding> standing { get; set; }

    }

    public class LeagueTable_links
    {
        public leaguetable_links_self self { get; set; }
        public LeagueTable_links_soccerseason soccerseason { get; set; }
    }

    // Secondary class.
    public class leaguetable_links_self
    {
        public string href { get; set; }
    }

    // Secondary class.
    public class LeagueTable_links_soccerseason
    {
        public string href { get; set; }
    }

    public class LeagueStanding
    {
        public Standing_links _links { get; set; }
        public int position { get; set; }
        public string teamName { get; set; }
        public string crestURI { get; set; }
        public int playedGames { get; set; }
        public int goals { get; set; }
        public int goalsAgainst { get; set; }
        public int goalDifference { get; set; }
        public int wins { get; set; }
        public int draws { get; set; }
        public int losses { get; set; }
        public Standing_home home { get; set; }
        public Standing_away away { get; set; }
    }

    
    public class Standing_links
    {
        public Standing_links_team team { get; set; }
    }

    //Secondary class.
    public class Standing_links_team
    {
        public string href { get; set; }
    }

    //Secondary class.
    public class Standing_home
    {
        public string goals { get; set; }
        public string goalsAgainst { get; set; }
        public string wins { get; set; }
        public string draws { get; set; }
        public string losses { get; set; }
    }

    //Secondary class.
    public class Standing_away
    {
        public string goals { get; set; }
        public string goalsAgainst { get; set; }
        public string wins { get; set; }
        public string draws { get; set; }
        public string losses { get; set; }
    }


}
