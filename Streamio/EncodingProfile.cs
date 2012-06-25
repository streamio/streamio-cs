using System;
using System.Collections.Generic;

namespace Streamio
{
	public class EncodingProfile
	{
		public string id { get; set; }
		public string title { get; set; }
		public List<string> tags { get; set; }
		public uint width { get; set; }
		public uint desired_video_bitrate { get; set; }
		public float frame_rate { get; set; }
		public uint audio_bitrate { get; set; }
		public uint audio_sample_rate { get; set; }
		public uint audio_channels { get; set; }
		public DateTime updated_at { get; set; }
		public DateTime created_at { get; set; }
		public string account_id { get; set; }
	}
}
