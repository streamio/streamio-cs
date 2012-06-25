using System;
using System.Collections.Generic;

namespace Streamio
{
	public class Image
	{
		public string id { get; set; }
		public string title { get; set; }
		public List<string> tags { get; set; }
		public List<ImageTranscoding> transcodings { get; set; }
		public DateTime updated_at { get; set; }
		public DateTime created_at { get; set; }
		public string account_id { get; set; }
	}
}

