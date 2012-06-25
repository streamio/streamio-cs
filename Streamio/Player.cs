using System;
using System.Collections.Generic;

namespace Streamio
{
	public class Player
	{
		public string id { get; set; }
		public string title { get; set; }
		public List<string> tags { get; set; }
		public uint width { get; set; }
		public uint height { get; set; }
		public bool autoplay { get; set; }
		public bool loop { get; set; }
		public bool enable_rtmp { get; set; }
		public bool show_elapsed_time { get; set; }
		public bool show_full_screen_button { get; set; }
		public bool show_large_play_button { get; set; }
		public bool show_play_pause_button { get; set; }
		public bool show_seek_bar { get; set; }
		public bool show_share_button { get; set; }
		public bool show_title { get; set; }
		public bool show_total_time { get; set; }
		public bool show_volume_control { get; set; }
		public string skin { get; set; }
		public string smartclip_preroll_url { get; set; }
		public string smartclip_html5_preroll_url { get; set; }
		public string google_analytics_property_id { get; set; }
		public string player_template_id { get; set; }
		public bool playlist { get; set; }
		public uint limit { get; set; }
		public string css { get; set; }
		public List<string> playlist_ids { get; set; }
		public DateTime updated_at { get; set; }
		public DateTime created_at { get; set; }
		public string account_id { get; set; }
	}
}

