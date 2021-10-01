using System.ComponentModel.DataAnnotations;

namespace SoccerAPI.Models
{
	public class Fixture
	{
        [Key]
		public int Id { get; set; }
        [Required]
        public string HomeTeam { get; set; }
        [Required]
        public string AwayTeam { get; set; }
        public int HomeScore { get; set; }
        public int AwayScore { get; set; }
        [Required]
        public string FixtureDateTime { get; set; }
    }
}
