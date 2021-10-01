using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoccerAPI.Models
{
	public class JsonFixture
	{
		public int id { get; set; }
		public int? league_id { get; set; }
		//public int? season_id { get; set; }
		//public int? stage_id { get; set; }
		//public int? round_id { get; set; }
		//public int? group_id { get; set; }
		//public int? aggregate_id { get; set; }
		public int? venue_id { get; set; }
		//public int? referee_id { get; set; }
		public int? localteam_id { get; set; }
		public int? visitorteam_id { get; set; }
		public int? winner_team_id { get; set; }
		//public struct weather_report
		//{
		//          string code, type, icon;
		//          struct temperature
		//	{
		//              double temp;
		//              string unit;
		//	}
		//          struct temperature_celcius
		//          {
		//              double temp;
		//              string unit;
		//          }
		//          string clouds, humidity, pressure;
		//          struct wind
		//	{
		//              string speed;
		//              double degree;
		//	}
		//	struct coordinates
		//	{
		//              double lat;
		//              double lon;
		//	}
		//          //string updated_at;
		//      }
		//public bool? commentaries { get; set; }
		public int? attendance { get; set; }
		public string pitch { get; set; }
		public string details { get; set; }
		//public bool? neutral_venue { get; set; }
		//public bool? winning_odds_calculated { get; set; }
		//public struct formations
		//{
		//          string localteam_formation, visitorteam_formation;
		//      }
		public Dictionary<string, object> scores { get; set; }

		//	public int? localteam_score, visitorteam_score, localteam_pen_score, visitorteam_pen_score;
		//	public string ht_score, ft_score, et_score, ps_score;
		public JObject time { get; set; }
		public Dictionary<string, Dictionary<string, object>> localTeam { get; set; }

		public Dictionary<string, Dictionary<string, object>> visitorTeam { get; set; }
	}
	
}
