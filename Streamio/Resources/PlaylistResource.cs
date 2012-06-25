using System;
using System.Collections.Generic;
using RestSharp;

namespace Streamio.Resources
{
	public class PlaylistResource : Resource
	{
		public PlaylistResource(RestClient api) : base(api)
		{
			resource = "playlists";
			accessableAttributes = new string[] {"title", "tags", "order_by", "order_direction"};
		}

		public List<Playlist> List(Dictionary<string, object> parameters)
		{ return base.List<Playlist>(parameters); }

		public Playlist Find(string id)
		{ return base.Find<Playlist>(id); }

		public Playlist Create(Dictionary<string, object> parameters)
		{ return base.Create<Playlist>(parameters); }
	}
}
