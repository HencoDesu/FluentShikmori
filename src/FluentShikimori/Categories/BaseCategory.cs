using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using FluentShikimori.Data;
using Newtonsoft.Json;

namespace FluentShikimori.Categories
{
	public class BaseCategory
	{
		private const int RequestsPerSecond = 5;
		private readonly HttpClient _httpClient;
		private readonly string _baseUrl;

		protected BaseCategory(HttpClient httpClient, string baseUrl)
		{
			_httpClient = httpClient;
			_baseUrl = baseUrl;
		}

		protected async Task<TResult?> GetAsync<TResult>(string requestPath, 
														 IReadOnlyDictionary<string, object> parameters)
		{
			await Task.Delay(1000 / RequestsPerSecond);
			
			var fullPath = BuildUri(_baseUrl + requestPath, parameters);
			var httpRequest = new HttpRequestMessage(HttpMethod.Get, fullPath);
			var httpResponse = await _httpClient.SendAsync(httpRequest);

			if (!httpResponse.IsSuccessStatusCode)
			{
				throw new Exception($"ShikimoriRequest error: {httpResponse.StatusCode}");
			}

			var response = await httpResponse.Content.ReadAsStringAsync();
			return HandleResponse<TResult>(response);
		}

		private static TResult? HandleResponse<TResult>(string response)
		{
			try
			{
				return JsonConvert.DeserializeObject<TResult>(response);
			} catch (JsonSerializationException)
			{
				return default;
			}
		}
		
		private static Uri BuildUri(string baseUri, IReadOnlyDictionary<string, object> parameters)
		{
			var stringBuilder = new StringBuilder(baseUri);
			var first = true;
			var appendFormat = "?{0}={1}";
			foreach (var (name, value) in parameters)
			{
				switch (value)
				{
					case IEnumerable enumerable:
						stringBuilder.AppendFormat(appendFormat, name, BuildEnumerable(enumerable));
						break;
					case RateStatus:
						stringBuilder.AppendFormat(appendFormat, name, value.ToString()?.ToLower());
						break;
					default:
						stringBuilder.AppendFormat(appendFormat, name, value);
						break;
				}

				if (first)
				{
					appendFormat = "&{0}={1}";
					first = false;
				}
			}

			return new Uri(stringBuilder.ToString());
		}

		private static string BuildEnumerable(IEnumerable enumerable)
		{
			var builder = new StringBuilder();
			var first = true;
			var appendFormat = "{0}";

			foreach (var item in enumerable)
			{
				builder.AppendFormat(appendFormat, item);

				if (first)
				{
					appendFormat = ",{0}";
					first = false;
				}
			}

			return builder.ToString();
		}
	}
}