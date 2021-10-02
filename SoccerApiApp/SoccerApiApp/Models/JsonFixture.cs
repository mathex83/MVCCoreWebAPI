using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;

namespace SoccerApiApp.Models
{
	public class JsonFixture
	{
		public int id { get; set; }
		public int? league_id { get; set; }
		public int? venue_id { get; set; }
		public int? localteam_id { get; set; }
		public int? visitorteam_id { get; set; }
		public int? winner_team_id { get; set; }
		public int? attendance { get; set; }
		public string pitch { get; set; }
		public string details { get; set; }		

		/*localteam_score, visitorteam_score, localteam_pen_score, visitorteam_pen_score;
		ht_score, ft_score, et_score, ps_score; */
		public Dictionary<string, object> scores { get; set; }

		public JObject time { get; set; }
		public Dictionary<string, Dictionary<string, object>> localTeam { get; set; }

		public Dictionary<string, Dictionary<string, object>> visitorTeam { get; set; }

		public static List<Fixture> AddJsonFixtures()
		{
            Api api = new Api();
            RestClient client = new RestClient(api.BaseAddress + "fixtures/between/2021-09-01/" + api.nowYMD + api.Key +
                "&include=localTeam,visitorTeam");
            client.Timeout = -1;
            RestRequest request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            JsonFixture[] responseFixtureArray = (JsonFixture[])JObject.Parse(response.Content)["data"].
                ToObject(typeof(JsonFixture[]));
            List<Fixture> fixtureList = new List<Fixture>();
            for (int i = 0; i < responseFixtureArray.Length; i++)
            {
                JsonFixture jFixture = responseFixtureArray[i];
                var homeTeamData = jFixture.localTeam["data"];
                var awayTeamData = jFixture.visitorTeam["data"];
                var time = jFixture.time["starting_at"]["date_time"];
                fixtureList.Add(
                new Fixture()
                {
                    Id = (int)jFixture.id,
                    HomeTeam = homeTeamData["name"].ToString(),
                    AwayTeam = awayTeamData["name"].ToString(),
                    HomeScore = Convert.ToInt32(jFixture.scores["localteam_score"]),
                    AwayScore = Convert.ToInt32(jFixture.scores["visitorteam_score"]),
                    FixtureDateTime = time.ToString()
                }
                );
            }
            return fixtureList;
        }        
	}
}
