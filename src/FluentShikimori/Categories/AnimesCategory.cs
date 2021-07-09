using System.Collections.Generic;
using System.Net.Http;
using FluentShikimori.Categories.Abstractions;
using FluentShikimori.Data;
using FluentShikimori.Requests;

namespace FluentShikimori.Categories
{
	public class AnimesCategory : BaseEntryCategory<AnimeEntry>, IAnimes
	{
		public AnimesCategory(HttpClient httpClient, string baseUrl) 
			: base(httpClient, baseUrl + "/animes")
		{ }
		
		public FluentRequest<IReadOnlyCollection<IDictionary<ImageLink, string>>?> Screenshots(long animeId)
			=> new ($"/{animeId}/screenshots", GetAsync<IReadOnlyCollection<IDictionary<ImageLink, string>>>);
	}
}