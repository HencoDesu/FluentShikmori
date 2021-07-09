using System.Collections.Generic;
using FluentShikimori.Data;
using FluentShikimori.Requests;

namespace FluentShikimori.Categories.Abstractions
{
	public interface IBaseEntryCategory<TEntry> 
		where TEntry : BaseEntry
	{
		/// <summary>
		/// Get list of entries matching criteria
		/// </summary>
		/// <returns>List of entries that matches requested parameters</returns>
		FluentRequest<IReadOnlyCollection<TEntry>?> Get();
		
		/// <summary>
		/// Get entry by it id
		/// </summary>
		/// <param name="entryId">Entry id</param>
		/// <returns>Entry with requested id</returns>
		FluentRequest<TEntry?> GetById(long entryId);
		
		/// <summary>
		/// Get authors of entry
		/// </summary>
		/// <param name="entryId">Entry id</param>
		/// <returns>Authors of that entry</returns>
		FluentRequest<IReadOnlyCollection<Role>?> Roles(long entryId);
		
		/// <summary>
		/// Get similar entries
		/// </summary>
		/// <param name="entryId">Entry id</param>
		/// <returns>Similar entries</returns>
		FluentRequest<IReadOnlyCollection<TEntry>?> Similar(long entryId);
		
		/// <summary>
		/// Get related entries
		/// </summary>
		/// <param name="entryId">Entry id</param>
		/// <returns>Related entries</returns>
		FluentRequest<IReadOnlyCollection<RelatedEntry>?> Related(long entryId);
		
		/// <summary>
		/// Get franchise for that entry
		/// </summary>
		/// <param name="entryId">Entry id</param>
		/// <returns>Franchise</returns>
		FluentRequest<Franchise?> Franchise(long entryId);
		
		/// <summary>
		/// Get external links for that entry
		/// </summary>
		/// <param name="entryId">Entry id</param>
		/// <returns>External links</returns>
		FluentRequest<IReadOnlyCollection<ExternalLink>?> ExternalLinks(long entryId);
	}
}