using System;
using System.Collections.Generic;
using RestSharp;

namespace Streamio.Resources
{
	public class VideoResource : Resource
	{
		public VideoResource(RestClient api) : base(api)
		{
			resource = "videos";
			creatableAttributes = new string[] {"encoding_profile_ids", "encoding_profile_tags", "skip_default_encoding_profiles", "use_original_as_transcoding"};
			accessableAttributes = new string[] {"title", "description", "tags", "image_id"};
		}

		public List<Video> List(Dictionary<string, object> parameters)
		{ return base.List<Video>(parameters); }

		public Video Find(string id)
		{ return base.Find<Video>(id); }

		public Video Create(Dictionary<string, object> parameters)
		{ return base.Create<Video>(parameters); }

		protected override void AddCreatableParameters(RestRequest request, Dictionary<string, object> parameters)
		{
			base.AddCreatableParameters(request, parameters);
			if(parameters.ContainsKey("file")) request.AddFile("file", (String) parameters["file"]);
		}
	}
}
