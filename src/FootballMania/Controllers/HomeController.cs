using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using System.Net.Http;
using Newtonsoft.Json;
using FootballMania.Models;

namespace FootballMania.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // GET: /Home/GetSoccerSeasons
        [HttpGet]
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
                return View(soccerseasons[0]);
            }
        }

        //public IActionResult About()
        //{
        //    ViewData["Message"] = "Your application description page.";

        //    return View();
        //}

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}
