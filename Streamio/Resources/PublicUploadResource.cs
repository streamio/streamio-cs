using System;
using System.Collections.Generic;
using RestSharp;

namespace Streamio.Resources
{
	public class PublicUploadResource : Resource
	{
		public PublicUploadResource(IRestClient api) : base(api)
		{
			resource = "uploads";
			accessableAttributes = new string[] {"title", "tags"};
		}

		public List<PublicUpload> List(Dictionary<string, object> parameters)
		{ return base.List<PublicUpload>(parameters); }

		public PublicUpload Find(string id)
		{ return base.Find<PublicUpload>(id); }

		public PublicUpload Create(Dictionary<string, object> parameters)
		{ return base.Create<PublicUpload>(parameters); }
	}
}
