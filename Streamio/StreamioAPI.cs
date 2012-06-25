using System;
using RestSharp;

namespace Streamio
{
	public class StreamioAPI
	{
		const string BaseUrl = "https://streamio.com/api/v1";

		public readonly VideoResource Videos;

		public StreamioAPI(string username, string password)
		{
			RestClient client = new RestClient(BaseUrl);
			client.Authenticator = new HttpBasicAuthenticator(username, password);

			Videos = new VideoResource(client);
		}
	}
}
