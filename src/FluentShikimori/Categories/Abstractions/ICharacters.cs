using System.Collections.Generic;
using FluentShikimori.Data;
using FluentShikimori.Requests;

namespace FluentShikimori.Categories.Abstractions
{
	/// <summary>
	/// Characters related methods
	/// </summary>
	/// <remarks>
	/// Shikimori doc - https://shikimori.one/api/doc/1.0/characters
	/// </remarks>
	public interface ICharacters
	{
		/// <summary>
		/// Show a character
		/// </summary>
		/// <param name="id">Character id</param>
		/// <returns>Character with that id</returns>
		IFluentRequest<Character?> GetById(long id);
		
		/// <summary>
		/// Search character
		/// </summary>
		/// <returns>List of characters matches query</returns>
		IFluentRequest<IReadOnlyCollection<Character>?> Search();
	}
}