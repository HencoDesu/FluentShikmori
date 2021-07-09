using System.Collections.Generic;
using System.Net.Http;
using FluentShikimori.Categories.Abstractions;
using FluentShikimori.Data;
using FluentShikimori.Requests;

namespace FluentShikimori.Categories
{
	public class Animes : BaseCategory, IAnimes
	{
		protected Animes(HttpClient httpClient, string baseUrl) 
			: base(httpClient, baseUrl + "/animes")
		{ }

		public FluentRequest<IReadOnlyCollection<AnimeEntry>?> Get() 
			=> new (string.Empty, GetAsync<IReadOnlyCollection<AnimeEntry>>);

		public FluentRequest<AnimeEntry?> GetById(long entryId)
			=> new ("/{id}", GetAsync<AnimeEntry>);

		public FluentRequest<IReadOnlyCollection<Role>?> Roles(long entryId)
			=> new ("/{id}/roles", GetAsync<IReadOnlyCollection<Role>>);

		public FluentRequest<IReadOnlyCollection<AnimeEntry>?> Similar(long entryId)
			=> new ("/{id}/similar", GetAsync<IReadOnlyCollection<AnimeEntry>>);

		public FluentRequest<IReadOnlyCollection<RelatedEntry>?> Related(long entryId)
			=> new ("/{id}/related", GetAsync<IReadOnlyCollection<RelatedEntry>>);

		public FluentRequest<Franchise?> Franchise(long entryId)
			=> new ("/{id}/franchise", GetAsync<Franchise>);

		public FluentRequest<IReadOnlyCollection<ExternalLink>?> ExternalLinks(long entryId)
			=> new ("/{id}/external_links", GetAsync<IReadOnlyCollection<ExternalLink>>);

		public FluentRequest<IReadOnlyCollection<IDictionary<ImageLink, string>>?> Screenshots(long animeId)
			=> new ("/{id}/screenshots", GetAsync<IReadOnlyCollection<IDictionary<ImageLink, string>>>);
	}
}