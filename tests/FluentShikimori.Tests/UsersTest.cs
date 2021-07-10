using System.Net.Http;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FluentShikimori.Tests
{
	[TestFixture]
	public class UsersTest
	{
		[TestCase(135003, "HencoDesu")]
		public async Task GetUserTest(int userId, string userNickname)
		{
			var client = CreateApiInstance();

			var user = await client.Users.GetById(userId);
			Assert.NotNull(user);
			Assert.AreEqual(userId, user.Id);
			Assert.AreEqual(userNickname, user.Nickname);

			user = await client.Users.GetById(userId);
			Assert.NotNull(user);
			Assert.AreEqual(userId, user.Id);
			Assert.AreEqual(userNickname, user.Nickname);
		}
		
		private static IFluentShikimoriApi CreateApiInstance()
			=> new FluentShikimoriApi(new HttpClient());
	}
}