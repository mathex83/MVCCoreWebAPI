using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectApi.Models
{
	public class Match
	{
		[Required]
		public int HomeScore { get; set; }
		[Required]
		public int AwayScore { get; set; }
		[Required]
		public string HomeTeam { get; set; }
		[Required]
		public string AwayTeam { get; set; }
		[Required]
		public string Location { get; set; }
		[Required]
		public DateTime MatchTime { get; set; }
	}
}
