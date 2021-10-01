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
			Api api = new Api();			
			RestClient client = new RestClient(api.BaseAddress + "leagues/501?" + api.Key);
			client.Timeout = -1;
			RestRequest request = new RestRequest(Method.GET);
			IRestResponse response = client.Execute(request);
			League dataObject = (League)JObject.Parse(response.Content)["data"].ToObject((typeof(League)));
			ViewBag.Message = dataObject;
			return View();
		}
	}
}
