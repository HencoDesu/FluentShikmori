using System.Collections.Generic;
using System.Net.Http;
using FluentShikimori.Categories.Abstractions;
using FluentShikimori.Data;
using FluentShikimori.Requests;

namespace FluentShikimori.Categories
{
	public abstract class BaseEntryCategory<TEntry> : BaseCategory, IBaseEntryCategory<TEntry> 
		where TEntry : BaseEntry
	{
		protected BaseEntryCategory(HttpClient httpClient, string baseUrl) 
			: base(httpClient, baseUrl)
		{ }
		
		public FluentRequest<IReadOnlyCollection<TEntry>?> Get() 
			=> new (string.Empty, GetAsync<IReadOnlyCollection<TEntry>>);

		public FluentRequest<TEntry?> GetById(long entryId)
			=> new ($"/{entryId}", GetAsync<TEntry>);

		public FluentRequest<IReadOnlyCollection<Role>?> Roles(long entryId)
			=> new ($"/{entryId}/roles", GetAsync<IReadOnlyCollection<Role>>);

		public FluentRequest<IReadOnlyCollection<TEntry>?> Similar(long entryId)
			=> new ($"/{entryId}/similar", GetAsync<IReadOnlyCollection<TEntry>>);

		public FluentRequest<IReadOnlyCollection<RelatedEntry>?> Related(long entryId)
			=> new ($"/{entryId}/related", GetAsync<IReadOnlyCollection<RelatedEntry>>);

		public FluentRequest<Franchise?> Franchise(long entryId)
			=> new ($"/{entryId}/franchise", GetAsync<Franchise>);

		public FluentRequest<IReadOnlyCollection<ExternalLink>?> ExternalLinks(long entryId)
			=> new ($"/{entryId}/external_links", GetAsync<IReadOnlyCollection<ExternalLink>>);

	}
}