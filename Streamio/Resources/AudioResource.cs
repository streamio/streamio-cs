using System;
using System.Collections.Generic;
using RestSharp;

namespace Streamio.Resources
{
	public class AudioResource : Resource
	{
		public AudioResource(IRestClient client) : base(client)
		{
			resource = "audios";
			accessableAttributes = new string[] {"title", "description", "tags"};
		}
        
        public List<Audio> List()
        { return base.List<Audio>(new Dictionary<string, object>()); }

		public List<Audio> List(Dictionary<string, object> parameters)
		{ return base.List<Audio>(parameters); }

		public Audio Find(string id)
		{ return base.Find<Audio>(id); }

		public Audio Create(Dictionary<string, object> parameters)
		{ return base.Create<Audio>(parameters); }

		protected override void AddCreatableParameters(RestRequest request, Dictionary<string, object> parameters)
		{
			base.AddCreatableParameters(request, parameters);
			if(parameters.ContainsKey("file")) request.AddFile("file", (String) parameters["file"]);
		}
	}
}
