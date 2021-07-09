using System.Net.Http;
using FluentShikimori.Categories.Abstractions;
using FluentShikimori.Data;

namespace FluentShikimori.Categories
{
	public class MangasCategory : BaseEntryCategory<MangaEntry>, IMangas
	{
		public MangasCategory(HttpClient httpClient, string baseUrl) 
			: base(httpClient, baseUrl + "/manga")
		{ }
	}
}