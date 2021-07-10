using System.Collections.Generic;
using System.Net.Http;
using FluentShikimori.Data;
using FluentShikimori.Requests;

namespace FluentShikimori.Categories.Abstractions
{
	public class UserRatesCategory : BaseCategory, IUserRates
	{
		public UserRatesCategory(HttpClient httpClient, string baseUrl) 
			: base(httpClient, baseUrl + "/2.0/user_rates")
		{ }

		public GetUserRatesFluentRequest Get()
			=> new(string.Empty, GetAsync<IReadOnlyCollection<UserRate>>);

		public FluentRequest<UserRate?> GetById(long userRateId)
			=> new(string.Empty, GetAsync<UserRate>);
	}
}