using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoccerAPI.Models
{
	public class League
	{
		public int Id { get; set; }
		public string LeagueName { get; set; }
		public List<Team> LeagueTeams { get; set; }

        /*
		 * {
    "data": {
        "id": 501,
        "active": true,
        "type": "domestic",
        "legacy_id": 66,
        "country_id": 1161,
        "logo_path": "https://cdn.sportmonks.com/images/soccer/leagues/501.png",
        "name": "Premiership",
        "is_cup": false,
        "is_friendly": false,
        "current_season_id": 18369,
        "current_round_id": 247437,
        "current_stage_id": 77453684,
        "live_standings": true,
        "coverage": {
            "predictions": true,
            "topscorer_goals": true,
            "topscorer_assists": true,
            "topscorer_cards": true
        }
    },
    "meta": {
        "plans": [
            {
                "name": "Football Free Plan",
                "features": "Standard",
                "request_limit": "180,60",
                "sport": "Soccer"
            }
        ],
        "sports": [
            {
                "id": 1,
                "name": "Soccer",
                "current": true
            }
        ]
    }
}
		 */
    }
}
