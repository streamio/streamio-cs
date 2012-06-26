using System;
using System.Collections.Generic;
using RestSharp;

namespace Streamio.Resources
{
	public class EncodingProfileResource : Resource
	{
		public EncodingProfileResource(IRestClient client) : base(client)
		{
			resource = "encoding_profiles";
			accessableAttributes = new string[] {"title", "tags", "width", "desired_video_bitrate", "frame_rate", "audio_bitrate", "audio_sample_rate", "audio_channels"};
		}

		public List<EncodingProfile> List(Dictionary<string, object> parameters)
		{ return base.List<EncodingProfile>(parameters); }

		public EncodingProfile Find(string id)
		{ return base.Find<EncodingProfile>(id); }

		public EncodingProfile Create(Dictionary<string, object> parameters)
		{ return base.Create<EncodingProfile>(parameters); }
	}
}
