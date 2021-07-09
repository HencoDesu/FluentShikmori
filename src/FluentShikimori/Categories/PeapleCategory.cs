using System.Collections.Generic;
using System.Net.Http;
using FluentShikimori.Categories.Abstractions;
using FluentShikimori.Data;
using FluentShikimori.Requests;

namespace FluentShikimori.Categories
{
	public class PeopleCategory : BaseCategory, IPeople
	{
		public PeopleCategory(HttpClient httpClient, string baseUrl) 
			: base(httpClient, baseUrl + "/people")
		{ }
		
		public FluentRequest<Person?> GetById(long id)
			=> new ($"/{id}", GetAsync<Person>);

		public FluentRequest<IReadOnlyCollection<Person>?> Search()
			=> new ("/search", GetAsync<IReadOnlyCollection<Person>>);
	}
}