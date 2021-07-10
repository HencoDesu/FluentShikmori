using System.Net.Http;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FluentShikimori.Tests
{
	[TestFixture]
	public class AnimesTest
	{
		[TestCase(20, "Naruto")]
		public async Task GetAnimeTest(long animeId, string animeName)
		{
			var client = CreateApiInstance();
			var response = await client.Animes.GetById(animeId);

			Assert.NotNull(response);
			Assert.AreEqual(animeName, response.Name);
		}

		private static IFluentShikimoriApi CreateApiInstance()
			=> new FluentShikimoriApi(new HttpClient());
	}
}