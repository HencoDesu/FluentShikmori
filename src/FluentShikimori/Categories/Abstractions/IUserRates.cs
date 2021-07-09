using System.Collections.Generic;
using FluentShikimori.Data;
using FluentShikimori.Requests;

namespace FluentShikimori.Categories.Abstractions
{
	/// <summary>
	/// User rates related methods
	/// </summary>
	/// <remarks>
	/// Shikimori doc - https://shikimori.one/api/doc/2.0/user_rates
	/// </remarks>
	public interface IUserRates
	{
		/// <summary>
		/// Get all user rates
		/// </summary>
		/// <returns></returns>
		FluentRequest<IReadOnlyCollection<UserRate>?> Get();

		/// <summary>
		/// Get user rate by it's id
		/// </summary>
		/// <param name="userRateId">User rate id</param>
		/// <returns></returns>
		FluentRequest<UserRate?> GetById(long userRateId);
	}
}