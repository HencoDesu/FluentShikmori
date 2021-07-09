using System.Net.Http;
using FluentShikimori.Categories.Abstractions;
using FluentShikimori.Data;

namespace FluentShikimori.Categories
{
	public class RanobeCategory : BaseEntryCategory<RanobeEntry>, IRanobe
	{
		public RanobeCategory(HttpClient httpClient, string baseUrl) 
			: base(httpClient, baseUrl + "/ranobe")
		{ }
	}
}