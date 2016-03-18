using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootballMania.Models;
using FootballMania.Controllers;

namespace FootballMania.Simulation
{
    public class FixtureSimulator
    {

        private SingleTeam team1 { get; set; }
        private SingleTeam team2 { get; set; }

        private FixtureSimulatorModel fixtureSimulatorResult { get; set; }

        public FixtureSimulator(SingleTeam team1Id, SingleTeam team2Id)
        {
            team1 = team1Id;
            team2 = team2Id;
        }

        public FixtureSimulatorModel GetFixtureSimulation ()
        {
            // First Step - We have both the teams, get the list of players from both teams, ideally along with their ratings. 

            // Second Step - Calculate the team rating for each team. 

            // Third Step - pass team ratings and player ratings, also use their positions, to determine the outcome of the match. (Most important step.)

            // For Goals and Assists, we need to measure the probability of teams according to their ratings.
            // For all the other stuff, the probability needs to be 50-50 

            // IMPORTANT - need to keep in mind that the events depend on events that come/happen before them.For example, if a player is injured, he cannot get a card or score.
            // All types of events need to be added simultaneously. 

            // Need to set the key value with the final dictionary to minutes (<90) and the value as event objects. 
            return fixtureSimulatorResult;
        }
    }
}
