using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballMania.Models
{

    public class Teams
    {
        public int count { get; set; }
        public List<SingleTeam> teams { get; set; }
        public Team_links _links { get; set; }
    }

    public class Team_links
    {
        public TeamSelf self { get; set; }
        public TeamSoccerSeason players { get; set; }
    } 

    public class TeamSelf
    {
        public string href { get; set; }
    }

    public class TeamSoccerSeason
    {
        public string href { get; set; }
    }

    public class SingleTeam
    {
        public SingleTeam_links _links { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public string shortName { get; set; }
        public string squadMarketValue { get; set; }
        public string crestUrl { get; set; }
    }

    public class SingleTeamSelf
    {
        public string href { get; set; }
    }

    public class SingleTeamPlayers
    {
        public string href { get; set; }
    }

    public class SingleTeamFixtures
    {
        public string href { get; set; }
    }

    public class SingleTeam_links
    {
        public SingleTeamSelf self { get; set; }
        public SingleTeamPlayers players { get; set; }
        public SingleTeamFixtures fixtures { get; set; }
    }
}
