using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace FootballMania
{
    public class FootballAPI
    {
        public async void GetFootballData()
        {
            using (HttpClient client = new HttpClient())
            {
                var baseUri = "http://www.football-data.org/v1/soccerseasons/";
                client.BaseAddress = new Uri(baseUri);
                client.DefaultRequestHeaders.Add("X-Auth-Token", "7b049d5b78124b76be75081c53975451");
                var response = await client.GetAsync(baseUri);
                if(response.IsSuccessStatusCode)
                {
                    var responseJson = await response.Content.ReadAsStringAsync();
                    var soccerseasons = JsonConvert.DeserializeObject<List<Season>>(responseJson);                   
                }               
                
            }
        }
    }

    public class Season
    {
        public _links _links{ get; set; }
        public string caption { get; set; }
        public string league { get; set; }
        public string year { get; set; }
        public int numberOfTeams { get; set; }
        public int numberOfGames { get; set; }
        public string lastupdated { get; set; }
    }

    public class self
    {
        public string href { get; set; }
    }

    public class teams
    {
        public string href { get; set; }
    }

    public class fixtures
    {
        public string href { get; set; }
    }

    public class _links
{
        public self self { get; set; }
        public teams teams { get; set; }
        public fixtures fixtures { get; set; }
    }
}
