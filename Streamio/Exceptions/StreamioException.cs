using System;
using RestSharp;

namespace Streamio
{
	public class StreamioException : Exception
	{
		private string message;

		public IRestResponse Response;

		public StreamioException(IRestResponse response)
		{
			Response = response;
			message = "Unexpected response status " + ((int) response.StatusCode).ToString() + " with body:\n" + response.Content;
		}

		public override string Message
		{
			get { return message; }
		}
	}
}

