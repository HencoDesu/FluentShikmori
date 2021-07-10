using System.Collections.Generic;
using FluentShikimori.Data;
using FluentShikimori.Requests;

namespace FluentShikimori.Categories.Abstractions
{
	/// <summary>
	/// Anime related methods
	/// </summary>
	/// <remarks>
	/// Shikimori doc - https://shikimori.one/api/doc/1.0/animes
	/// </remarks>
	public interface IAnimes : IBaseEntryCategory<AnimeEntry>
	{
		/// <summary>
		/// Get list of animes matching criteria
		/// </summary>
		/// <returns>List of entries that matches requested parameters</returns>
		new GetAnimesFluentRequest Get();
		
		/// <summary>
		/// Get anime screenshots
		/// </summary>
		/// <param name="animeId">anime id</param>
		/// <returns></returns>
		FluentRequest<IReadOnlyCollection<IDictionary<ImageLink, string>>?> Screenshots(long animeId);
	}
}