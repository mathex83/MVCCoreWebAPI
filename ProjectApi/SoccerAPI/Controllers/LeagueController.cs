using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using RestSharp;
using SoccerAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoccerAPI.Controllers
{
	public class LeagueController : Controller
	{
		public IActionResult League()
		{

			string apiString = "api_token=2WPKee3pGNARMqtnhznGwIRCHMfIGvtL2xGQuMBrsNGpFZzGJU7xzlsdTo9G";
			RestClient client = new RestClient("https://soccer.sportmonks.com/api/v2.0/leagues/501?" + apiString);
			client.Timeout = -1;
			RestRequest request = new RestRequest(Method.GET);
			IRestResponse response = client.Execute(request);
			JsonLeague dataObject = (JsonLeague)JObject.Parse(response.Content)["data"].ToObject((typeof(JsonLeague)));

			ViewBag.Message = dataObject;
			return View();
		}
	}
}
