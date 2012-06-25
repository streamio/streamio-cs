using System;
using System.Collections.Generic;

namespace Streamio
{
	public class Audio
	{
		public string id { get; set; }
		public string title { get; set; }
		public string description { get; set; }
		public List<string> tags { get; set; }
		public float duration { get; set; }
		public uint plays { get; set; }
		public string state { get; set; }
		public float progress { get; set; }
		public OriginalFile original_file { get; set; }
		public DateTime updated_at { get; set; }
		public DateTime created_at { get; set; }
		public string account_id { get; set; }
	}
}
