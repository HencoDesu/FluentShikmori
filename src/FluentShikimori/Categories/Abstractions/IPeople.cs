using System.Collections.Generic;
using FluentShikimori.Data;
using FluentShikimori.Requests;

namespace FluentShikimori.Categories.Abstractions
{
	/// <summary>
	/// People related methods
	/// </summary>
	/// <remarks>
	/// Shikimori doc - https://shikimori.one/api/doc/1.0/people
	/// </remarks>
	public interface IPeople
	{
		/// <summary>
		/// Show a person
		/// </summary>
		/// <param name="id">Person id</param>
		/// <returns>Person with that id</returns>
		FluentRequest<Person?> GetById(long id);
		
		/// <summary>
		/// Search person
		/// </summary>
		/// <returns>List of person matches query</returns>
		FluentRequest<IReadOnlyCollection<Person>?> Search();
	}
}