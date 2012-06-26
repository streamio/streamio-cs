using System;
using System.Collections.Generic;
using RestSharp;

namespace Streamio.Resources
{
	public class PlayerResource : Resource
	{
		public PlayerResource(IRestClient client) : base(client)
		{
			resource = "players";
			accessableAttributes = new string[] {"title", "tags", "width", "height", "skin", "loop", "autoplay", "enable_rtmp", "show_title", "show_play_pause_button", "show_elapsed_time", "show_seek_bar", "show_total_time", "show_volume_control", "show_full_screen_button", "show_share_button", "show_large_play_button", "google_analytics_property_id", "smartclip_preroll_url", "smartclip_html5_preroll_url", "playlist", "limit", "css"};
		}

		public List<Player> List(Dictionary<string, object> parameters)
		{ return base.List<Player>(parameters); }

		public Player Find(string id)
		{ return base.Find<Player>(id); }

		public Player Create(Dictionary<string, object> parameters)
		{ return base.Create<Player>(parameters); }
	}
}
