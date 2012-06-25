using System;
using RestSharp;
using Streamio.Resources;

namespace Streamio
{
	public class StreamioAPI
	{
		const string BaseUrl = "https://streamio.com/api/v1";

		public readonly VideoResource Videos;
		public readonly ImageResource Images;
		public readonly PlaylistResource Playlists;
		public readonly PlayerResource Players;
		public readonly AudioResource Audios;
		public readonly EncodingProfileResource EncodingProfiles;
		public readonly PublicUploadResource PublicUploads;

		public StreamioAPI(string username, string password)
		{
			RestClient client = new RestClient(BaseUrl);
			client.Authenticator = new HttpBasicAuthenticator(username, password);

			Videos = new VideoResource(client);
			Images = new ImageResource(client);
			Playlists = new PlaylistResource(client);
			Players = new PlayerResource(client);
			Audios = new AudioResource(client);
			EncodingProfiles = new EncodingProfileResource(client);
			PublicUploads = new PublicUploadResource(client);
		}
	}
}
