using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoccerAPI.Models
{
	public class Fixture
	{
        [Key]
		public int Id { get; set; }             //id
        [Required]
        public string HomeTeam { get; set; }    //localteam_id
        [Required]
        public string AwayTeam { get; set; }    //visitorteam_id
        public int HomeScore { get; set; }      //scores.localteam_score
        public int AwayScore { get; set; }      //scores.visitorteam_score
        [Required]
        public string FixtureDateTime { get; set; }     //time.starting_at.date_time

    }
}
