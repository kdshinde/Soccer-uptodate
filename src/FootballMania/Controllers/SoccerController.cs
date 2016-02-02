using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using System.Net.Http;
using Newtonsoft.Json;
using FootballMania.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace FootballMania.Controllers
{
    [Route("api/[controller]")]
    public class SoccerController : Controller
    {
        // GET: api/Soccer/GetSoccerSeasons
        [HttpGet("GetSoccerSeasons")]
        public async Task<IActionResult> GetSoccerSeasons()
        {
            using (HttpClient client = new HttpClient())
            {
                var baseUri = "http://www.football-data.org/v1/soccerseasons/";
                client.BaseAddress = new Uri(baseUri);
                client.DefaultRequestHeaders.Add("X-Auth-Token", "7b049d5b78124b76be75081c53975451");
                var response = await client.GetAsync(baseUri);
                List<Season> soccerseasons = new List<Season>();
                if (response.IsSuccessStatusCode)
                {
                    var responseJson = await response.Content.ReadAsStringAsync();
                    soccerseasons = JsonConvert.DeserializeObject<List<Season>>(responseJson);
                }
                return new ObjectResult(soccerseasons);
            }
        }

        // GET: api/Soccer/GetAllFixtures
        [HttpGet("GetAllFixtures")]
        public async Task<IActionResult> GetAllFixtures()
        {
            using (HttpClient client = new HttpClient())
            {
                var baseUri = "http://www.football-data.org/v1/fixtures/";
                client.BaseAddress = new Uri(baseUri);
                client.DefaultRequestHeaders.Add("X-Auth-Token", "7b049d5b78124b76be75081c53975451");
                var response = await client.GetAsync(baseUri);
                FootballFixtures fixtures = new FootballFixtures();
                if (response.IsSuccessStatusCode)
                {
                    var responseJson = await response.Content.ReadAsStringAsync();
                    fixtures = JsonConvert.DeserializeObject<FootballFixtures>(responseJson);
                }
                return new ObjectResult(fixtures);
            }
        }

        // GET: api/Soccer/GetLeagueTeams
        [HttpGet("GetLeagueTeams")]
        public async Task<IActionResult> GetLeagueTeams(string LeagueId)
        {
            // Need to decide if the whole link will be sent or if the id. Because we are sending the whole link to the UI as a string (href) 
            using (HttpClient client = new HttpClient())
            {
                var baseUri = "http://www.football-data.org/v1/soccerseasons/" + LeagueId + "/teams";
                client.BaseAddress = new Uri(baseUri);
                client.DefaultRequestHeaders.Add("X-Auth-Token", "7b049d5b78124b76be75081c53975451");
                var response = await client.GetAsync(baseUri);
                LeagueTeams leagueteams = new LeagueTeams();
                if (response.IsSuccessStatusCode)
                {
                    var responseJson = await response.Content.ReadAsStringAsync();
                    leagueteams = JsonConvert.DeserializeObject<LeagueTeams>(responseJson);
                }
                return new ObjectResult(leagueteams);
            }
        }

        // GET: api/Soccer/GetLeagueFixtures
        [HttpGet("GetLeagueFixtures")]
        public async Task<IActionResult> GetLeagueFixtures(string LeagueId)
        {
            // Need to decide if the whole link will be sent or if the id. Because we are sending the whole link to the UI as a string (href) 
            using (HttpClient client = new HttpClient())
            {
                var baseUri = "http://www.football-data.org/v1/soccerseasons/" + LeagueId + "/fixtures";
                client.BaseAddress = new Uri(baseUri);
                client.DefaultRequestHeaders.Add("X-Auth-Token", "7b049d5b78124b76be75081c53975451");
                var response = await client.GetAsync(baseUri);
                LeagueFixtures leaguefixtures = new LeagueFixtures();
                if (response.IsSuccessStatusCode)
                {
                    var responseJson = await response.Content.ReadAsStringAsync();
                    leaguefixtures = JsonConvert.DeserializeObject<LeagueFixtures>(responseJson);
                    
                }
                return new ObjectResult(leaguefixtures);
            }
        }

        // GET: api/Soccer/GetLeagueTable
        [HttpGet("GetLeagueTable")]
        public async Task<IActionResult> GetLeagueTable(string LeagueId)
        {
            // Need to decide if the whole link will be sent or if the id. Because we are sending the whole link to the UI as a string (href) 
            using (HttpClient client = new HttpClient())
            {
                var baseUri = "http://www.football-data.org/v1/soccerseasons/" + LeagueId + "/leagueTable";
                client.BaseAddress = new Uri(baseUri);
                client.DefaultRequestHeaders.Add("X-Auth-Token", "7b049d5b78124b76be75081c53975451");
                var response = await client.GetAsync(baseUri);
                LeagueTable leaguetable = new LeagueTable();
                if (response.IsSuccessStatusCode)
                {
                    var responseJson = await response.Content.ReadAsStringAsync();
                    leaguetable = JsonConvert.DeserializeObject<LeagueTable>(responseJson);

                }
                return new ObjectResult(leaguetable);
            }
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
