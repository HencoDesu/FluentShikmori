using System.Collections.Generic;
using System.Net.Http;
using FluentShikimori.Categories.Abstractions;
using FluentShikimori.Data;
using FluentShikimori.Requests;

namespace FluentShikimori.Categories
{
	public class CharacterCategory : BaseCategory, ICharacters
	{
		public CharacterCategory(HttpClient httpClient, string baseUrl) 
			: base(httpClient, baseUrl + "/characters")
		{ }
		
		public FluentRequest<Character?> GetById(long id)
			=> new ($"/{id}", GetAsync<Character>);

		public FluentRequest<IReadOnlyCollection<Character>?> Search()
			=> new ("/search", GetAsync<IReadOnlyCollection<Character>>);
	}
}