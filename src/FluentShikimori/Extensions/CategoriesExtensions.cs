using System.Collections.Generic;
using FluentShikimori.Categories.Abstractions;
using FluentShikimori.Data;
using FluentShikimori.Requests;

namespace FluentShikimori.Extensions
{
	public static class CategoriesExtensions
	{
		public static IFluentRequest<IReadOnlyCollection<IDictionary<ImageLink, string>>?> Screenshots(
			this IAnimes animes, 
			AnimeEntry anime)
			=> animes.Screenshots(anime.Id);

		/// <summary>
		/// Get authors of entry
		/// </summary>
		/// <param name="category">Entry category</param>
		/// <param name="entry">Entry</param>
		/// <typeparam name="TEntry">Entry type</typeparam>
		/// <returns>Authors of that entry</returns>
		public static IFluentRequest<IReadOnlyCollection<Role>?> Roles<TEntry>(
			this IBaseEntryCategory<TEntry> category, 
			TEntry entry) 
			where TEntry : BaseEntry
			=> category.Roles(entry.Id);
		
		/// <summary>
		/// Get similar entries
		/// </summary>
		/// <param name="category">Entry category</param>
		/// <param name="entry">Entry</param>
		/// <typeparam name="TEntry">Entry type</typeparam>
		/// <returns>Similar entries</returns>
		public static IFluentRequest<IReadOnlyCollection<TEntry>?> Similar<TEntry>(
			this IBaseEntryCategory<TEntry> category, 
			TEntry entry) 
			where TEntry : BaseEntry
			=> category.Similar(entry.Id);
		
		/// <summary>
		/// Get related entries
		/// </summary>
		/// <param name="category">Entry category</param>
		/// <param name="entry">Entry</param>
		/// <typeparam name="TEntry">Entry type</typeparam>
		/// <returns>Related entries</returns>
		public static IFluentRequest<IReadOnlyCollection<RelatedEntry>?> Related<TEntry>(
			this IBaseEntryCategory<TEntry> category, 
			TEntry entry) 
			where TEntry : BaseEntry
			=> category.Related(entry.Id);
		
		/// <summary>
		/// Get franchise for that entry
		/// </summary>
		/// <param name="category">Entry category</param>
		/// <param name="entry">Entry</param>
		/// <typeparam name="TEntry">Entry type</typeparam>
		/// <returns>Franchise</returns>
		public static IFluentRequest<Franchise?> Franchise<TEntry>(
			this IBaseEntryCategory<TEntry> category, 
			TEntry entry) 
			where TEntry : BaseEntry
			=> category.Franchise(entry.Id);
		
		/// <summary>
		/// Get external links for that entry
		/// </summary>
		/// <param name="category">Entry category</param>
		/// <param name="entry">Entry</param>
		/// <typeparam name="TEntry">Entry type</typeparam>
		/// <returns>External links</returns>
		public static IFluentRequest<IReadOnlyCollection<ExternalLink>?> ExternalLinks<TEntry>(
			this IBaseEntryCategory<TEntry> category, 
			TEntry entry) 
			where TEntry : BaseEntry
			=> category.ExternalLinks(entry.Id);
	}
}