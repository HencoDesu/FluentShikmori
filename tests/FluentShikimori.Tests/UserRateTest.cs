using System.Net.Http;
using System.Threading.Tasks;
using FluentShikimori.Data;
using NUnit.Framework;

namespace FluentShikimori.Tests
{
	[TestFixture]
	public class UserRateTest
	{
		[TestCase(135003, 39535)]
		public async Task GetUserRateTest(int userId, int animeId)
		{
			var client = CreateApiInstance();
			var userRates = await client.UserRates
										.Get()
										.WithUserId(userId)
										.WithTargetType(DataType.Anime)
										.WithTargetId(animeId);

			Assert.NotNull(userRates);
			Assert.IsNotEmpty(userRates);
			Assert.AreEqual(1, userRates.Count);
		}
		
		private static IFluentShikimoriApi CreateApiInstance()
			=> new FluentShikimoriApi(new HttpClient());
	}
}