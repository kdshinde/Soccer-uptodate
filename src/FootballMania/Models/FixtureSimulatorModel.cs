using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballMania.Models
{
    public class FixtureSimulatorModel
    {
        // This is a dictionary of events, where the key will the minutes of the game, and the value will be a pairing of the player, along with the associated event. 
        Dictionary<int, FixtureEvents> fixtureEvents { get; set; }
    }

    internal class FixtureEvents
    {
       // public PlayerModel player { get; set; } - Unnecessary in this particular scenario.
       public string playerName { get; set; }
       public MatchEvent matchEvent { get; set; }
    }

    public enum MatchEvent
    {
        RedCard,
        YellowCard,
        Injury,
        Goal,
        Assist,
        Substitution,
        HalfTime,
        FullTime
    }
}
