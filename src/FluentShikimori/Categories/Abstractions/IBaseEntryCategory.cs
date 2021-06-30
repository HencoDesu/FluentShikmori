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
		IFluentRequest<IReadOnlyCollection<TEntry>?> Get();
		
		/// <summary>
		/// Get entry by it id
		/// </summary>
		/// <param name="entryId">Entry id</param>
		/// <returns>Entry with requested id</returns>
		IFluentRequest<TEntry?> GetById(long entryId);
		
		/// <summary>
		/// Get authors of entry
		/// </summary>
		/// <param name="entryId">Entry id</param>
		/// <returns>Authors of that entry</returns>
		IFluentRequest<IReadOnlyCollection<Role>?> Roles(long entryId);
		
		/// <summary>
		/// Get similar entries
		/// </summary>
		/// <param name="entryId">Entry id</param>
		/// <returns>Similar entries</returns>
		IFluentRequest<IReadOnlyCollection<TEntry>?> Similar(long entryId);
		
		/// <summary>
		/// Get related entries
		/// </summary>
		/// <param name="entryId">Entry id</param>
		/// <returns>Related entries</returns>
		IFluentRequest<IReadOnlyCollection<RelatedEntry>?> Related(long entryId);
		
		/// <summary>
		/// Get franchise for that entry
		/// </summary>
		/// <param name="entryId">Entry id</param>
		/// <returns>Franchise</returns>
		IFluentRequest<Franchise?> Franchise(long entryId);
		
		/// <summary>
		/// Get external links for that entry
		/// </summary>
		/// <param name="entryId">Entry id</param>
		/// <returns>External links</returns>
		IFluentRequest<IReadOnlyCollection<ExternalLink>?> ExternalLinks(long entryId);
	}
}