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
        // GET: /Soccer/GetSoccerSeasons
        //[Route("api/Soccer/GetSoccerSeasons")]
        //[HttpGet]
        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get()
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
