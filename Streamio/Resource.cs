using System;
using System.Collections.Generic;
using RestSharp;

namespace Streamio
{
	public class Resource
	{
		protected string resource;
		protected RestClient api;

		protected string[] creatableAttributes;
		protected string[] accessableAttributes;

		public Resource(RestClient api)
		{
			this.api = api;
			creatableAttributes = new string[0];
			accessableAttributes = new string[0];
		}

		public T Find<T>(string id) where T : new()
		{
			return api.Execute<T>(new RestRequest(resource + "/" + id)).Data;
		}

		public List<T> List<T>(Dictionary<string, object> parameters) where T : new()
		{
			RestRequest request = new RestRequest(resource);
			foreach(KeyValuePair<string, object> parameter in parameters)
			{
				request.AddParameter(parameter.Key, parameter.Value);
			}
			return api.Execute<List<T>>(request).Data;
		}

		public uint Count(Dictionary<string, object> parameters)
		{
			RestRequest request = new RestRequest(resource + "/count");
			foreach(KeyValuePair<string, object> parameter in parameters)
			{
				request.AddParameter(parameter.Key, parameter.Value);
			}
			return api.Execute<Count>(request).Data.count;
		}

		public T Create<T>(Dictionary<string, object> parameters) where T : new()
		{
			RestRequest request = new RestRequest(resource, Method.POST);
			AddCreatableParameters(request, parameters);
			AddAccessableParameters(request, parameters);
			return api.Execute<T>(request).Data;
		}

		public void Update(string id, Dictionary<string, object> parameters)
		{
			RestRequest request = new RestRequest(resource + "/" + id, Method.PUT);
			AddAccessableParameters(request, parameters);
			api.Execute(request);
		}

		public void Delete(string id)
		{
			RestRequest request = new RestRequest(resource + "/" + id, Method.DELETE);
			api.Execute(request);
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
	}
}

