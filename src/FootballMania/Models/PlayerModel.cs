using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballMania.Models
{
    public class PlayerModel
    {
        public string name { get; set; }
        public string position { get; set; }
        public string jerseyNumber { get; set; }
        public string dateOfBirth { get; set; }
        public string nationality { get; set; }
        public string contractUntil { get; set; }
        public string marketValue { get; set; }
    }
}
