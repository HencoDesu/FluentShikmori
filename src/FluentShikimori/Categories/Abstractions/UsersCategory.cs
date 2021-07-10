using System.Collections.Generic;
using System.Net.Http;
using FluentShikimori.Data;
using FluentShikimori.Requests;

namespace FluentShikimori.Categories.Abstractions
{
	public class UsersCategory : BaseCategory, IUsers
	{
		public UsersCategory(HttpClient httpClient, string baseUrl) 
			: base(httpClient, baseUrl + "/users")
		{ }

		public FluentRequest<IReadOnlyCollection<User>?> Get()
			=> new(string.Empty, GetAsync<IReadOnlyCollection<User>>);

		public FluentRequest<User?> GetById(long userId)
			=> new($"/{userId}", GetAsync<User>);

		public FluentRequest<User?> GetById(string nickname)
			=> new FluentRequest<User?>($"/{nickname}", GetAsync<User>)
				.WithParameter("is_nickname", 1);

	}
}