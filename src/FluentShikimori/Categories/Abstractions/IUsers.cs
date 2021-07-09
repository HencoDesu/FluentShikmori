using System.Collections.Generic;
using FluentShikimori.Data;
using FluentShikimori.Requests;

namespace FluentShikimori.Categories.Abstractions
{
	/// <summary>
	/// User related methods
	/// </summary>
	/// <remarks>
	/// Shikimori doc - https://shikimori.one/api/doc/1.0/users
	/// </remarks>
	public interface IUsers
	{
		/// <summary>
		/// Get all users
		/// </summary>
		/// <returns></returns>
		FluentRequest<IReadOnlyCollection<User>?> Get();

		/// <summary>
		/// Get user by it's id
		/// </summary>
		/// <param name="userId">User rate id</param>
		/// <returns></returns>
		FluentRequest<User?> GetById(long userId);
		
		/// <summary>
		/// Get user by it's nickname
		/// </summary>
		/// <param name="nickname">User nickname</param>
		/// <returns></returns>
		FluentRequest<User?> GetById(string nickname);
	}
}