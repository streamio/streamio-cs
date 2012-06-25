using System;
using System.Collections.Generic;

namespace Streamio
{
	public class Video
	{
		public string id { get; set; }
		public string title { get; set; }
		public string description { get; set; }
		public List<string> tags { get; set; }
		public string image_id { get; set; }
		public float aspect_ratio_multiplier { get; set; }
		public float duration { get; set; }
		public uint plays { get; set; }
		public string state { get; set; }
		public float progress { get; set; }
		public List<VideoTranscoding> transcodings { get; set; }
		public Dictionary<string, string> screenshot { get; set; }
		public OriginalVideo original_video { get; set; }
		public DateTime updated_at { get; set; }
		public DateTime created_at { get; set; }
		public string account_id { get; set; }
	}
}

