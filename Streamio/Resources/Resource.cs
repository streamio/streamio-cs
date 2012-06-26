using System;
using System.Collections.Generic;
using RestSharp;

namespace Streamio.Resources
{
	public class Resource
	{
		protected string resource;
		protected string[] creatableAttributes;
		protected string[] accessableAttributes;

		private IRestClient client;

		public Resource(IRestClient client)
		{
			this.client = client;
			creatableAttributes = new string[0];
			accessableAttributes = new string[0];
		}

		public T Find<T>(string id) where T : new()
		{
			return Execute<T>(new RestRequest(resource + "/" + id)).Data;
		}

		public List<T> List<T>(Dictionary<string, object> parameters) where T : new()
		{
			RestRequest request = new RestRequest(resource);
			foreach(KeyValuePair<string, object> parameter in parameters)
			{
				request.AddParameter(parameter.Key, parameter.Value);
			}
			return Execute<List<T>>(request).Data;
		}

		public uint Count(Dictionary<string, object> parameters)
		{
			RestRequest request = new RestRequest(resource + "/count");
			foreach(KeyValuePair<string, object> parameter in parameters)
			{
				request.AddParameter(parameter.Key, parameter.Value);
			}
			return Execute<Count>(request).Data.count;
		}

		public T Create<T>(Dictionary<string, object> parameters) where T : new()
		{
			RestRequest request = new RestRequest(resource, Method.POST);
			AddCreatableParameters(request, parameters);
			AddAccessableParameters(request, parameters);
			return Execute<T>(request).Data;
		}

		public void Update(string id, Dictionary<string, object> parameters)
		{
			RestRequest request = new RestRequest(resource + "/" + id, Method.PUT);
			AddAccessableParameters(request, parameters);
			Execute(request);
		}

		public void Delete(string id)
		{
			RestRequest request = new RestRequest(resource + "/" + id, Method.DELETE);
			Execute(request);
		}

		protected virtual void AddCreatableParameters(RestRequest request, Dictionary<string, object> parameters)
		{
			foreach(string attribute in creatableAttributes)
			{
				if(parameters.ContainsKey(attribute)) request.AddParameter(attribute, parameters[attribute]);
			}
		}

		protected virtual void AddAccessableParameters(RestRequest request, Dictionary<string, object> parameters)
		{
			foreach(string attribute in accessableAttributes)
			{
				if(parameters.ContainsKey(attribute)) request.AddParameter(attribute, parameters[attribute]);
			}
		}

		private IRestResponse Execute(IRestRequest request)
		{
			IRestResponse response = client.Execute(request);
			checkResponse(response);
			return response;
		}

		private IRestResponse<T> Execute<T>(IRestRequest request) where T : new()
		{
			IRestResponse<T> response = client.Execute<T>(request);
			checkResponse(response);
			return response;
		}

		private void checkResponse(IRestResponse response)
		{
			int code = (int) response.StatusCode;
			if(code == 422)
			{
				throw new StreamioValidationException(response);
			}
			else if(code >= 400)
			{
				throw new StreamioException(response);
			}
		}
	}
}

