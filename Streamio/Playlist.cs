using System;
using System.Collections.Generic;

namespace Streamio
{
	public class Playlist
	{
		public string id { get; set; }
		public string title { get; set; }
		public List<string> tags { get; set; }
		public string order_by { get; set; }
		public string order_direction { get; set; }
		public DateTime updated_at { get; set; }
		public DateTime created_at { get; set; }
		public string account_id { get; set; }
	}
}
