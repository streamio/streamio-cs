using System;

namespace Streamio
{
	public class AudioTranscoding
	{
		public string id { get; set; }
		public string title { get; set; }
		public uint size { get; set; }
		public string state { get; set; }
		public float progress { get; set; }
		public string http_uri { get; set; }
		public uint width { get; set; }
		public uint height { get; set; }
	}
}

