using System;
using System.Collections.Generic;
using RestSharp;

namespace Streamio.Resources
{
	public class ImageResource : Resource
	{
		public ImageResource(IRestClient client) : base(client)
		{
			resource = "images";
			accessableAttributes = new string[] {"title", "tags"};
		}

		public List<Image> List(Dictionary<string, object> parameters)
		{ return base.List<Image>(parameters); }

		public Image Find(string id)
		{ return base.Find<Image>(id); }

		public Image Create(Dictionary<string, object> parameters)
		{ return base.Create<Image>(parameters); }

		protected override void AddCreatableParameters(RestRequest request, Dictionary<string, object> parameters)
		{
			base.AddCreatableParameters(request, parameters);
			if(parameters.ContainsKey("file")) request.AddFile("file", (String) parameters["file"]);
		}
	}
}
