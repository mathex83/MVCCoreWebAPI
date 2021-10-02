using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoccerApiApp.Models
{
	public class Fixture
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
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
