using System;

namespace SoccerApiApp.Models
{
	public class Api
	{
		public string Key { get { return "?api_token=2WPKee3pGNARMqtnhznGwIRCHMfIGvtL2xGQuMBrsNGpFZzGJU7xzlsdTo9G"; } }
		public string BaseAddress { get { return "https://soccer.sportmonks.com/api/v2.0/"; } }
		public string nowYMD { get { return DateTime.Now.ToString("yyyy-MM-dd"); } }
	}
}
