using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace SoccerAPI.Models
{
	public class League
	{
		public int Id { get; set; }
		//public bool Active { get; set; }
		//public string Type { get; set; }
		//public string LegacyId { get; set; }
		//public int CountryId { get; set; }
		//public string LogoPath { get; set; }
		public string Name { get; set; }
		//public bool IsCup { get; set; }
		//public bool IsFriendly { get; set; }
		//public int CurrentSeasonId { get; set; }
		//public int CurrentRoundId { get; set; }
		//public int CurrentStageId { get; set; }
		//public bool LiveStandings { get; set; }
		//"coverage": { "predictions": true, "topscorer_goals": true, "topscorer_assists": true, "topscorer_cards": true
		public Dictionary<string,bool> Coverage { get; set; }
	}
	
}
